﻿using UnityEngine;

namespace VLB
{
    public static class Consts
    {
        const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";
        public const string HelpUrlBeam = HelpUrlBase + "comp-lightbeam/";
        public const string HelpUrlDustParticles = HelpUrlBase + "comp-dustparticles/";
        public const string HelpUrlDynamicOcclusion = HelpUrlBase + "comp-dynocclusion/";
        public const string HelpUrlTriggerZone = HelpUrlBase + "comp-triggerzone/";
        public const string HelpUrlConfig = HelpUrlBase + "config/";

        public static readonly bool ProceduralObjectsVisibleInEditor = true;
        public static HideFlags ProceduralObjectsHideFlags { get { return ProceduralObjectsVisibleInEditor ? (HideFlags.NotEditable | HideFlags.DontSave) : (HideFlags.HideAndDontSave); } }

        public static readonly Color FlatColor = Color.white;
        public const ColorMode ColorModeDefault = ColorMode.Flat;

        public const float Alpha = 1f;
        public const float SpotAngleDefault = 35f;
        public const float SpotAngleMin = 0.1f;
        public const float SpotAngleMax = 179.9f;
        public const float ConeRadiusStart = 0.1f;
        public const int GeomSidesDefault = 18;
        public const int GeomSidesMin = 3;
        public const int GeomSidesMax = 256;
        public const bool GeomCap = false;

        public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;
        public const float AttenuationCustomBlending = 0.5f;
        public const float FadeStart = 0f;
        public const float FadeEnd = 3f;
        public const float FadeMinThreshold = 0.01f;

        public const float DepthBlendDistance = 2f;
        public const float CameraClippingDistance = 0.5f;

        public const float FresnelPowMaxValue = 10f;
        public const float FresnelPow = 8f;

        public const float GlareFrontal = 0.5f;
        public const float GlareBehind = 0.5f;

        public const float NoiseIntensityDefault = 0.5f;

        public const float NoiseScaleMin = 0.01f;
        public const float NoiseScaleMax = 2f;
        public const float NoiseScaleDefault = 0.5f;

        public static readonly Vector3 NoiseVelocityDefault = new Vector3(0.07f, 0.18f, 0.05f);

        public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

        public static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor = new UnityEngine.Rendering.BlendMode[3]
        {
            UnityEngine.Rendering.BlendMode.One,                // Additive
            UnityEngine.Rendering.BlendMode.OneMinusDstColor,   // SoftAdditive
            UnityEngine.Rendering.BlendMode.SrcAlpha,           // TraditionalTransparency
        };

        public static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor = new UnityEngine.Rendering.BlendMode[3]
        {
            UnityEngine.Rendering.BlendMode.One,                // Additive
            UnityEngine.Rendering.BlendMode.One,                // SoftAdditive
            UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha,   // TraditionalTransparency
        };

        public static readonly bool[] BlendingMode_AlphaAsBlack = new bool[3]
        {
            true,   // Additive
            true,   // SoftAdditive
            false,  // TraditionalTransparency
        };
    }
}