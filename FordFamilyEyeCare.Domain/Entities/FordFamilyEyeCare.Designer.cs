﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace FordFamilyEyeCare.Domain.Entities
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EntityContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EntityContainer object using the connection string found in the 'EntityContainer' section of the application configuration file.
        /// </summary>
        public EntityContainer() : base("name=EntityContainer", "EntityContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        public EntityContainer(string connectionString) : base(connectionString, "EntityContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        public EntityContainer(EntityConnection connection) : base(connection, "EntityContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Insurance> Insurances
        {
            get
            {
                if ((_Insurances == null))
                {
                    _Insurances = base.CreateObjectSet<Insurance>("Insurances");
                }
                return _Insurances;
            }
        }
        private ObjectSet<Insurance> _Insurances;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Variable> Variables
        {
            get
            {
                if ((_Variables == null))
                {
                    _Variables = base.CreateObjectSet<Variable>("Variables");
                }
                return _Variables;
            }
        }
        private ObjectSet<Variable> _Variables;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ContactInformation> ContactInformations
        {
            get
            {
                if ((_ContactInformations == null))
                {
                    _ContactInformations = base.CreateObjectSet<ContactInformation>("ContactInformations");
                }
                return _ContactInformations;
            }
        }
        private ObjectSet<ContactInformation> _ContactInformations;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Insurances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInsurances(Insurance insurance)
        {
            base.AddObject("Insurances", insurance);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Variables EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVariables(Variable variable)
        {
            base.AddObject("Variables", variable);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ContactInformations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContactInformations(ContactInformation contactInformation)
        {
            base.AddObject("ContactInformations", contactInformation);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FordFamilyEyeCare.Entities", Name="ContactInformation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ContactInformation : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ContactInformation object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="viewed">Initial value of the Viewed property.</param>
        /// <param name="contacted">Initial value of the Contacted property.</param>
        public static ContactInformation CreateContactInformation(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.Boolean viewed, global::System.Boolean contacted)
        {
            ContactInformation contactInformation = new ContactInformation();
            contactInformation.Id = id;
            contactInformation.FirstName = firstName;
            contactInformation.LastName = lastName;
            contactInformation.Viewed = viewed;
            contactInformation.Contacted = contacted;
            return contactInformation;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Street
        {
            get
            {
                return _Street;
            }
            set
            {
                OnStreetChanging(value);
                ReportPropertyChanging("Street");
                _Street = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Street");
                OnStreetChanged();
            }
        }
        private global::System.String _Street;
        partial void OnStreetChanging(global::System.String value);
        partial void OnStreetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ZipCode
        {
            get
            {
                return _ZipCode;
            }
            set
            {
                OnZipCodeChanging(value);
                ReportPropertyChanging("ZipCode");
                _ZipCode = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ZipCode");
                OnZipCodeChanged();
            }
        }
        private Nullable<global::System.Int32> _ZipCode;
        partial void OnZipCodeChanging(Nullable<global::System.Int32> value);
        partial void OnZipCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdditionalInformation
        {
            get
            {
                return _AdditionalInformation;
            }
            set
            {
                OnAdditionalInformationChanging(value);
                ReportPropertyChanging("AdditionalInformation");
                _AdditionalInformation = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AdditionalInformation");
                OnAdditionalInformationChanged();
            }
        }
        private global::System.String _AdditionalInformation;
        partial void OnAdditionalInformationChanging(global::System.String value);
        partial void OnAdditionalInformationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Viewed
        {
            get
            {
                return _Viewed;
            }
            set
            {
                OnViewedChanging(value);
                ReportPropertyChanging("Viewed");
                _Viewed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Viewed");
                OnViewedChanged();
            }
        }
        private global::System.Boolean _Viewed;
        partial void OnViewedChanging(global::System.Boolean value);
        partial void OnViewedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Contacted
        {
            get
            {
                return _Contacted;
            }
            set
            {
                OnContactedChanging(value);
                ReportPropertyChanging("Contacted");
                _Contacted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Contacted");
                OnContactedChanged();
            }
        }
        private global::System.Boolean _Contacted;
        partial void OnContactedChanging(global::System.Boolean value);
        partial void OnContactedChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FordFamilyEyeCare.Entities", Name="Insurance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Insurance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Insurance object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="companyName">Initial value of the CompanyName property.</param>
        /// <param name="sortOrder">Initial value of the SortOrder property.</param>
        public static Insurance CreateInsurance(global::System.Int32 id, global::System.String companyName, global::System.Int32 sortOrder)
        {
            Insurance insurance = new Insurance();
            insurance.Id = id;
            insurance.CompanyName = companyName;
            insurance.SortOrder = sortOrder;
            return insurance;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyUrl
        {
            get
            {
                return _CompanyUrl;
            }
            set
            {
                OnCompanyUrlChanging(value);
                ReportPropertyChanging("CompanyUrl");
                _CompanyUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CompanyUrl");
                OnCompanyUrlChanged();
            }
        }
        private global::System.String _CompanyUrl;
        partial void OnCompanyUrlChanging(global::System.String value);
        partial void OnCompanyUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyLogo
        {
            get
            {
                return _CompanyLogo;
            }
            set
            {
                OnCompanyLogoChanging(value);
                ReportPropertyChanging("CompanyLogo");
                _CompanyLogo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CompanyLogo");
                OnCompanyLogoChanged();
            }
        }
        private global::System.String _CompanyLogo;
        partial void OnCompanyLogoChanging(global::System.String value);
        partial void OnCompanyLogoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SortOrder
        {
            get
            {
                return _SortOrder;
            }
            set
            {
                OnSortOrderChanging(value);
                ReportPropertyChanging("SortOrder");
                _SortOrder = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SortOrder");
                OnSortOrderChanged();
            }
        }
        private global::System.Int32 _SortOrder;
        partial void OnSortOrderChanging(global::System.Int32 value);
        partial void OnSortOrderChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FordFamilyEyeCare.Entities", Name="Variable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Variable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Variable object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Variable CreateVariable(global::System.Int32 id, global::System.String name)
        {
            Variable variable = new Variable();
            variable.Id = id;
            variable.Name = name;
            return variable;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.String _Value;
        partial void OnValueChanging(global::System.String value);
        partial void OnValueChanged();

        #endregion

    
    }

    #endregion

    
}