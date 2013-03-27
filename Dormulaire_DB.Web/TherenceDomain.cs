
namespace Dormulaire_DB.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the InscriptionEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class TherenceDomain : LinqToEntitiesDomainService<InscriptionEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Utilisateur' query.
        public IQueryable<Utilisateur> GetUtilisateur()
        {
            return this.ObjectContext.Utilisateur;
        }

        public void InsertUtilisateur(Utilisateur utilisateur)
        {
            if ((utilisateur.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(utilisateur, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Utilisateur.AddObject(utilisateur);
            }
        }

        public void UpdateUtilisateur(Utilisateur currentUtilisateur)
        {
            this.ObjectContext.Utilisateur.AttachAsModified(currentUtilisateur, this.ChangeSet.GetOriginal(currentUtilisateur));
        }

        public void DeleteUtilisateur(Utilisateur utilisateur)
        {
            if ((utilisateur.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(utilisateur, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Utilisateur.Attach(utilisateur);
                this.ObjectContext.Utilisateur.DeleteObject(utilisateur);
            }
        }
    }
}


