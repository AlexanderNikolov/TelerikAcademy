namespace CustomAttributes
{
    using System;
    using System.Linq;

    class VersionAttribute : Attribute
    {
        //.tor
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        //prop
        public string Version { get; set; }

        //overrides
        public override string ToString()
        {
            return this.Version;
        }
    }
}
