namespace ModularFootstepSystem.Extensions
{
    using UnityEngine;
    using UnityEngine.Rendering.HighDefinition;
    
    /// <summary>
    /// Enables the Decal feature in the current Render Pipeline Asset to ensure proper rendering of decals such as footprints.
    /// </summary>
    public static class DecalEnabler
    {
        /// <summary>
        /// Checks if the decal feature function is enabled.
        /// </summary>
        public static bool IsDecalsEnabled()
        {
            if (QualitySettings.renderPipeline is HDRenderPipelineAsset asset)
            {
                return asset.currentPlatformRenderPipelineSettings.supportDecals;
            }
            
            return false;
        }
        
        /// <summary>
        /// Enables the decals feature in the current Render Pipeline Asset.
        /// </summary>
        public static void EnableDecals()
        {
            HDRenderPipelineAsset asset = QualitySettings.renderPipeline as HDRenderPipelineAsset;
            
            if (!asset) return;
            
            RenderPipelineSettings settings = asset.currentPlatformRenderPipelineSettings;
            settings.supportDecals = true;
            asset.currentPlatformRenderPipelineSettings = settings;
        }
    }
}