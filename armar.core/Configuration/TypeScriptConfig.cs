namespace Armar.Core
{
    /// <summary>
    /// Class describing the TypeScript configuration that the CLI should use to generate TS code
    /// Inherits from JavaScript project structure and adds TypeScript specific configuration
    /// </summary>
    public class TypeScriptConfig : JavaScriptConfig
    {
        /// <summary>
        /// Specific TypeScript configuration properties
        /// </summary>
        public TSConfigSettings TypeScriptSettings { get; set; } = new();
    }

    /// <summary>
    /// Class indicating the TypeScript specific configuration (maps to tsconfig.json), currently only the compiler options are included
    /// </summary>
    public class TSConfigSettings
    {
        /// <summary>
        /// TypeScript compiler options properties
        /// </summary>
        public TSCompilerOptions CompilerOptions { get; set; } = new();
    }

    /// <summary>
    /// Class matching the TypeScript compiler options section of the tsconfig.json
    /// </summary>
    public class TSCompilerOptions
    {
        public bool ExperimentalDecorators { get; set; } = true;
        public bool EmitDecoratorMetadata { get; set; } = true;
        public string Module { get; set; } = "commonjs";
        public string Target { get; set; } = "es6";
        public string OutDir { get; set; } = "dist";
        public string RootDir { get; set; } = ".";
        public bool SourceMap { get; set; } = true;
        public bool Strict { get; set; } = true;
    }
}