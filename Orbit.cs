﻿#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// <para>An Orbit class represents a Keplerian orbit. Each Vessel and each CelestialBody has an Orbit. CelestialBodies and
/// on-rails Vessels follow their Orbits exactly. Off-rails vessels (the active vessel and any nearby vessels) 
/// do not follow their orbits exactly; instead their motion is computed frame-by-frame from the forces acting on them.</para>
/// <para>A patched consics trajectory consists of a series of Orbits, called patches.</para>
/// </summary>
[Serializable]
public class Orbit
{
    /// <summary>
    /// Whether this patch actually represents a real orbit patch in the projected flight path. Often
    /// Orbit.nextPatch for the last real will not be null, but will be some sort of bogus Orbit object.
    /// You can recognize these because activePatch will be false.
    /// </summary>
    public bool activePatch;
    public double altitude;
    public Vector3d an;
    public double argumentOfPeriapsis;
    public double ClAppr;
    public double ClEctr1;
    public double ClEctr2;
    public CelestialBody closestEncounterBody;
    public Orbit.EncounterSolutionLevel closestEncounterLevel;
    public Orbit closestEncounterPatch;
    public double closestTgtApprUT;
    public double CrAppr;
    public bool debug_returnFullEllipseTrajectory;
    public Vector3 debugAN;
    public Vector3 debugEccVec;
    public Vector3 debugH;
    public Vector3 debugPos;
    public Vector3 debugVel;
    public double E;
    public double eccentricAnomaly;
    /// <summary>
    /// The eccentricity of the orbit.
    /// </summary>
    public double eccentricity;
    /// <summary>
    /// A vector that points toward periapsis, with mangitude equal to the eccentricity.
    /// NOTE: All Vector3d's returned by Orbit class functions have their y and z axes flipped. You have
    /// to flip these back to get the vectors in world coordinates.
    /// </summary>
    public Vector3d eccVec;
    /// <summary>
    /// The universal time at which this patch ends.
    /// </summary>
    public double EndUT;
    public double epoch;
    public double FEVp;
    public double FEVs;
    public double fromE;
    public double fromV;
    public Vector3d h;
    /// <summary>
    /// The inclination of this orbit with respect to the equator of the central body (in radians or degrees?)
    /// </summary>
    public double inclination;
    /// <summary>
    /// The longitude of the ascending node of the orbit (in what coordinate system?)
    /// </summary>
    public double LAN;
    public double mag;
    public double meanAnomaly;
    public double meanAnomalyAtEpoch;
    public double nearestTT;
    public Orbit nextPatch;
    public double nextTT;
    [Obsolete("Use VesselType or CelestialBodyType instead")]
    public Orbit.ObjectType objectType;
    public double ObT;
    public double ObTAtEpoch;
    public double orbitalEnergy;
    public double orbitalSpeed;
    public double orbitPercent;
    public Orbit.PatchTransitionType patchEndTransition;
    public Orbit.PatchTransitionType patchStartTransition;
    /// <summary>
    /// The period of the orbit, in seconds.
    /// </summary>
    public double period;
    public Vector3d pos;
    public Orbit previousPatch;
    public double radius;
    /// <summary>
    /// The body orbited.
    /// </summary>
    public CelestialBody referenceBody;
    public double sampleInterval;
    public Vector3d secondaryPosAtTransition1;
    public Vector3d secondaryPosAtTransition2;
    /// <summary>
    /// The semi-major axis of the orbit, in meters. Equal to (PeR + ApR)/2
    /// </summary>
    public double semiMajorAxis;
    public double SEVp;
    public double SEVs;
    public double StartUT;
    /// <summary>
    /// The time until the object will reach apoapsis, in seconds.
    /// </summary>
    public double timeToAp;
    /// <summary>
    /// The time unti lthe object will reach periapsis, in seconds.
    /// </summary>
    public double timeToPe;
    public double timeToTransition1;
    public double timeToTransition2;
    public double toE;
    public double toV;
    public double trueAnomaly;
    public double UTappr;
    public double UTsoi;
    public double V;
    public Vector3d vel;

    public extern Orbit();
    public extern Orbit(double inc, double e, double sma, double lan, double w, double mEp, double t, CelestialBody body);

    /// <summary>
    /// The apoapsis of the orbit in meters, measured from sea level.
    /// </summary>
    public extern double ApA { get; }
    /// <summary>
    /// The apoapsis of the orbit in meters, measured from the center of the main body.
    /// </summary>
    public extern double ApR { get; }
    /// <summary>
    /// The periapsis of the orbit in meters, measured from sea level.
    /// </summary>
    public extern double PeA { get; }
    /// <summary>
    /// The periapsis of the orbit in meters, measured from the center of the main body.
    /// </summary>
    public extern double PeR { get; }
    public extern double semiLatusRectum { get; }
    public extern double semiMinorAxis { get; }

    public extern void DrawOrbit();
    public extern static void FindClosestPoints(Orbit p, Orbit s, ref double CD, ref double CCD, ref double FFp, ref double FFs, ref double SFp, ref double SFs, double epsilon, int maxIterations, ref int iterationCount);
    public extern Vector3d GetANVector();
    public extern double GetDTforTrueAnomaly(double tA, double wrapAfterSeconds);
    public extern double GetEccentricAnomaly(double tA);
    public extern Vector3d GetEccVector();
    public extern Vector3d GetFrameVel();
    public extern Vector3d GetFrameVelAtUT(double UT);
    public extern double GetMeanAnomaly(double E, double tA);
    public extern double getObTAtMeanAnomaly(double M);
    public extern double getObtAtUT(double UT);
    public extern double getOrbitalSpeedAt(double time);
    public extern double getOrbitalSpeedAtDistance(double d);
    public extern double getOrbitalSpeedAtPos(Vector3d pos);
    public extern double getOrbitalSpeedAtRelativePos(Vector3d relPos);
    public extern Vector3d getOrbitalVelocityAtObT(double ObT);
    public extern Vector3d getOrbitalVelocityAtUT(double UT);
    /// <summary>
    /// A unit vector normal to the plane of the orbit. NOTE: All Vector3d's returned by Orbit class functions have their y and z axes flipped. You have
    /// to flip these back to get the vectors in world coordinates.
    /// </summary>
    /// <returns>A unit normal vector.</returns>
    public extern Vector3d GetOrbitNormal();
    public extern Trajectory GetPatchTrajectory(int sampleCount);
    public extern Vector3d getPositionAtT(double T);
    public extern Vector3d getPositionAtUT(double UT);
    public extern Vector3d getPositionFromEccAnomaly(double E);
    public extern Vector3d getPositionFromMeanAnomaly(double M);
    public extern Vector3d getPositionFromTrueAnomaly(double tA);
    public extern Vector3d getRelativePositionAtT(double T);
    /// <summary>
    /// Gets the predicted displacement of the orbiting object from the center of the main
    /// body at a given universal time. NOTE: All Vector3d's returned by Orbit class functions have their y and z axes flipped. You have
    /// to flip these back to get the vectors in world coordinates.
    /// </summary>
    /// <param name="UT">A univeral time.</param>
    /// <returns>Position relative to the main body (YZ flipped)</returns>
    public extern Vector3d getRelativePositionAtUT(double UT);
    public extern Vector3d getRelativePositionFromEccAnomaly(double E);
    public extern Vector3d getRelativePositionFromMeanAnomaly(double M);
    public extern Vector3d getRelativePositionFromTrueAnomaly(double tA);
    public extern Vector3d GetRelativeVel();
    public extern Vector3d GetRotFrameVel(CelestialBody refBody);
    public extern double getTrueAnomaly(double E);
    public extern double GetTrueAnomalyOfZupVector(Vector3d vector);
    public extern Vector3d getTruePositionAtUT(double UT);
    public extern double GetUTforTrueAnomaly(double tA, double wrapAfterSeconds);
    /// <summary>
    /// The current orbital velocity of the orbiting body. Unlike most other methods of the orbit
    /// class, the returned vector seems to already be in world coordinates and doesn't need to have
    /// its Y and Z axes flipped.
    /// </summary>
    /// <returns>Orbital velocity vector at current time.</returns>
    public extern Vector3d GetVel();
    public extern Vector3d GetWorldSpaceVel();
    public extern void Init();
    public extern static bool PeApIntersects(Orbit primary, Orbit secondary, double threshold);
    /// <summary>
    /// The distance the orbiting object will be from the center of the main body when it reaches the given true anomaly.
    /// </summary>
    /// <param name="tA">True anomaly (in degrees or radians?)</param>
    /// <returns>Distance from the main body's center, in meters</returns>
    public extern double RadiusAtTrueAnomaly(double tA);
    public extern static double SolveClosestApproach(Orbit p, Orbit s, ref double UT, double dT, double threshold, double MinUT, double MaxUT, double epsilon, int maxIterations, ref int iterationCount);
    public extern double solveEccentricAnomaly(double M, double ecc, double maxError, int maxIterations);
    public extern static bool SolveSOI_BSP(Orbit p, Orbit s, ref double UT, double dT, double Rsoi, double MinUT, double MaxUT, double epsilon, int maxIterations, ref int iterationCount);
    /// <summary>
    /// The true anomaly at which the orbiting object will achieve the given distance from the center of the main body.
    /// </summary>
    /// <param name="R">Distance from the center of the main body, in meters.</param>
    /// <returns>True anomaly, in radians.</returns>
    public extern double TrueAnomalyAtRadius(double R);
    public extern double TrueAnomalyAtT(double T);
    public extern double TrueAnomalyAtUT(double UT);
    public extern void UpdateFromOrbitAtUT(Orbit orbit, double UT, CelestialBody toBody);
    /// <summary>
    /// Updates this orbit to reflect the orbit that will be taken around the given body by an object with the
    /// given position and velocity at the given universal time.
    /// </summary>
    /// <param name="pos">The initial position of the object RELATIVE TO refBody at UT (YZ flipped)</param>
    /// <param name="vel">The initial velocity of the object (YZ flipped)</param>
    /// <param name="refBody">The main body</param>
    /// <param name="UT">The universal time at which to start the orbit.</param>
    public extern void UpdateFromStateVectors(Vector3d pos, Vector3d vel, CelestialBody refBody, double UT);
    public extern void UpdateFromUT(double UT);

    public enum EncounterSolutionLevel
    {
        NONE = 0,
        ESCAPE = 1,
        ORBIT_INTERSECT = 2,
        SOI_INTERSECT_2 = 3,
        SOI_INTERSECT_1 = 4,
    }

    public enum ObjectType
    {
        VESSEL = 0,
        SPACE_DEBRIS = 1,
        CELESTIAL_BODIES = 2,
        UNKNOWN_MISC = 3,
        KERBAL = 4,
    }

    public enum PatchTransitionType
    {
        INITIAL = 0,
        FINAL = 1,
        ENCOUNTER = 2,
        ESCAPE = 3,
        MANEUVER = 4,
    }
}
