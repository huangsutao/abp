using System;
using Volo.Abp.AspNetCore.VirtualFileSystem;
using Volo.Abp.Minify.Scripts;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bundling.Scripts
{
    public class ScriptBundler : BundlerBase, IScriptBundler
    {
        public override string FileExtension => "js";

        public ScriptBundler(IWebContentFileProvider webContentFileProvider, IJavascriptMinifier minifier)
            : base(webContentFileProvider, minifier)
        {
        }

        protected override string ProcessBeforeAddingToTheBundle(IBundlerContext context, string filePath, string fileContent)
        {
            return fileContent.EnsureEndsWith(';') + Environment.NewLine;
        }
    }
}