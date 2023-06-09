//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.32
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace ITRM.Entities {
    
    
    [TableOptions(TableName="E_ITRM_Requests")]
    public class E_ITRM_RequestsEntity : FormEntity<E_ITRM_RequestsEntity> {
        
        private E_ITRM_RequestsVREntity _VersionEntity;
        
        private RDEntityCollection<E_ITRM_RequestsRDEntity, E_ITRM_RequestsRDMLEntity> _RD;
        
        private RDCEntityCollection<E_ITRM_RequestsRDCEntity, E_ITRM_RequestsRDCMLEntity> _RDC;
        
        public E_ITRM_RequestsEntity() {
            this.VersionEntity = new E_ITRM_RequestsVREntity();
            this.RD = new RDEntityCollection<E_ITRM_RequestsRDEntity, E_ITRM_RequestsRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_ITRM_RequestsRDCEntity, E_ITRM_RequestsRDCMLEntity>();
        }
        
        public E_ITRM_RequestsVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_ITRM_RequestsRDEntity, E_ITRM_RequestsRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_ITRM_RequestsRDCEntity, E_ITRM_RequestsRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
    }
    
    [TableOptions(TableName="E_ITRM_RequestsVR")]
    public class E_ITRM_RequestsVREntity : VersionEntity<E_ITRM_RequestsVREntity> {
    }
    
    [TableOptions(TableName="E_ITRM_RequestsRDC")]
    public class E_ITRM_RequestsRDCEntity : RDCEntity<E_ITRM_RequestsRDCEntity, E_ITRM_RequestsRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_ITRM_RequestsRDCML")]
    public class E_ITRM_RequestsRDCMLEntity : RDCMLEntity<E_ITRM_RequestsRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_ITRM_RequestsRD")]
    public class E_ITRM_RequestsRDEntity : RDEntity<E_ITRM_RequestsRDEntity, E_ITRM_RequestsRDMLEntity> {
    }
    
    [TableOptions(TableName="E_ITRM_RequestsRDML")]
    public class E_ITRM_RequestsRDMLEntity : RDMLEntity<E_ITRM_RequestsRDMLEntity> {
    }
}




