//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dormulaire_DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// Context for the RIA application.
    /// </summary>
    /// <remarks>
    /// This context extends the base to make application services and types available
    /// for consumption from code and xaml.
    /// </remarks>
    public sealed partial class WebContext : WebContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the WebContext class.
        /// </summary>
        public WebContext()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the context that is registered as a lifetime object with the current application.
        /// </summary>
        /// <exception cref="InvalidOperationException"> is thrown if there is no current application,
        /// no contexts have been added, or more than one context has been added.
        /// </exception>
        /// <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
        public new static WebContext Current
        {
            get
            {
                return ((WebContext)(WebContextBase.Current));
            }
        }
    }
}
namespace Dormulaire_DB.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'TherenceDomain' DomainService.
    /// </summary>
    public sealed partial class TherenceDomain : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TherenceDomain"/> class.
        /// </summary>
        public TherenceDomain() : 
                this(new WebDomainClient<ITherenceDomainContract>(new Uri("Dormulaire_DB-Web-TherenceDomain.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TherenceDomain"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The TherenceDomain service URI.</param>
        public TherenceDomain(Uri serviceUri) : 
                this(new WebDomainClient<ITherenceDomainContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TherenceDomain"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public TherenceDomain(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="Utilisateur"/> entity instances that have been loaded into this <see cref="TherenceDomain"/> instance.
        /// </summary>
        public EntitySet<Utilisateur> Utilisateurs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<Utilisateur>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="Utilisateur"/> entity instances using the 'GetUtilisateur' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="Utilisateur"/> entity instances.</returns>
        public EntityQuery<Utilisateur> GetUtilisateurQuery()
        {
            this.ValidateMethod("GetUtilisateurQuery", null);
            return base.CreateQuery<Utilisateur>("GetUtilisateur", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new TherenceDomainEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'TherenceDomain' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface ITherenceDomainContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetUtilisateur' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TherenceDomain/GetUtilisateurDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TherenceDomain/GetUtilisateur", ReplyAction="http://tempuri.org/TherenceDomain/GetUtilisateurResponse")]
            [WebGet()]
            IAsyncResult BeginGetUtilisateur(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetUtilisateur'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetUtilisateur'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetUtilisateur' operation.</returns>
            QueryResult<Utilisateur> EndGetUtilisateur(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TherenceDomain/SubmitChangesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TherenceDomain/SubmitChanges", ReplyAction="http://tempuri.org/TherenceDomain/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class TherenceDomainEntityContainer : EntityContainer
        {
            
            public TherenceDomainEntityContainer()
            {
                this.CreateEntitySet<Utilisateur>(EntitySetOperations.All);
            }
        }
    }
    
    /// <summary>
    /// The 'Utilisateur' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Dormulaire_DB.Web")]
    public sealed partial class Utilisateur : Entity
    {
        
        private Nullable<DateTime> _age;
        
        private byte[] _avatar;
        
        private string _email;
        
        private string _nom;
        
        private string _peuso;
        
        private string _prenom;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnageChanging(Nullable<DateTime> value);
        partial void OnageChanged();
        partial void OnavatarChanging(byte[] value);
        partial void OnavatarChanged();
        partial void OnemailChanging(string value);
        partial void OnemailChanged();
        partial void OnnomChanging(string value);
        partial void OnnomChanged();
        partial void OnpeusoChanging(string value);
        partial void OnpeusoChanged();
        partial void OnprenomChanging(string value);
        partial void OnprenomChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Utilisateur"/> class.
        /// </summary>
        public Utilisateur()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'age' value.
        /// </summary>
        [DataMember()]
        public Nullable<DateTime> age
        {
            get
            {
                return this._age;
            }
            set
            {
                if ((this._age != value))
                {
                    this.OnageChanging(value);
                    this.RaiseDataMemberChanging("age");
                    this.ValidateProperty("age", value);
                    this._age = value;
                    this.RaiseDataMemberChanged("age");
                    this.OnageChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'avatar' value.
        /// </summary>
        [DataMember()]
        public byte[] avatar
        {
            get
            {
                return this._avatar;
            }
            set
            {
                if ((this._avatar != value))
                {
                    this.OnavatarChanging(value);
                    this.RaiseDataMemberChanging("avatar");
                    this.ValidateProperty("avatar", value);
                    this._avatar = value;
                    this.RaiseDataMemberChanged("avatar");
                    this.OnavatarChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'email' value.
        /// </summary>
        [DataMember()]
        [StringLength(10)]
        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                if ((this._email != value))
                {
                    this.OnemailChanging(value);
                    this.RaiseDataMemberChanging("email");
                    this.ValidateProperty("email", value);
                    this._email = value;
                    this.RaiseDataMemberChanged("email");
                    this.OnemailChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'nom' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [Required()]
        [RoundtripOriginal()]
        [StringLength(10)]
        public string nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                if ((this._nom != value))
                {
                    this.OnnomChanging(value);
                    this.ValidateProperty("nom", value);
                    this._nom = value;
                    this.RaisePropertyChanged("nom");
                    this.OnnomChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'peuso' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(10)]
        public string peuso
        {
            get
            {
                return this._peuso;
            }
            set
            {
                if ((this._peuso != value))
                {
                    this.OnpeusoChanging(value);
                    this.RaiseDataMemberChanging("peuso");
                    this.ValidateProperty("peuso", value);
                    this._peuso = value;
                    this.RaiseDataMemberChanged("peuso");
                    this.OnpeusoChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'prenom' value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(10)]
        public string prenom
        {
            get
            {
                return this._prenom;
            }
            set
            {
                if ((this._prenom != value))
                {
                    this.OnprenomChanging(value);
                    this.RaiseDataMemberChanging("prenom");
                    this.ValidateProperty("prenom", value);
                    this._prenom = value;
                    this.RaiseDataMemberChanged("prenom");
                    this.OnprenomChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._nom;
        }
    }
}
