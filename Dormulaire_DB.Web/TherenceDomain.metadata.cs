
namespace Dormulaire_DB.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies UtilisateurMetadata as the class
    // that carries additional metadata for the Utilisateur class.
    [MetadataTypeAttribute(typeof(Utilisateur.UtilisateurMetadata))]
    public partial class Utilisateur
    {

        // This class allows you to attach custom attributes to properties
        // of the Utilisateur class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class UtilisateurMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private UtilisateurMetadata()
            {
            }

            public Nullable<DateTime> age { get; set; }

            public Nullable<bool> avatar { get; set; }

            public string email { get; set; }

            public string nom { get; set; }

            public string peuso { get; set; }

            public string prenom { get; set; }
        }
    }
}
