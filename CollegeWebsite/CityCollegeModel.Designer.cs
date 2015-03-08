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
namespace CollegeWebsite
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ASPNETDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ASPNETDBEntities object using the connection string found in the 'ASPNETDBEntities' section of the application configuration file.
        /// </summary>
        public ASPNETDBEntities() : base("name=ASPNETDBEntities", "ASPNETDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ASPNETDBEntities object.
        /// </summary>
        public ASPNETDBEntities(string connectionString) : base(connectionString, "ASPNETDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ASPNETDBEntities object.
        /// </summary>
        public ASPNETDBEntities(EntityConnection connection) : base(connection, "ASPNETDBEntities")
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
        public ObjectSet<CourseList> CourseLists
        {
            get
            {
                if ((_CourseLists == null))
                {
                    _CourseLists = base.CreateObjectSet<CourseList>("CourseLists");
                }
                return _CourseLists;
            }
        }
        private ObjectSet<CourseList> _CourseLists;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EnrolList> EnrolLists
        {
            get
            {
                if ((_EnrolLists == null))
                {
                    _EnrolLists = base.CreateObjectSet<EnrolList>("EnrolLists");
                }
                return _EnrolLists;
            }
        }
        private ObjectSet<EnrolList> _EnrolLists;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WebsiteUpload> WebsiteUploads
        {
            get
            {
                if ((_WebsiteUploads == null))
                {
                    _WebsiteUploads = base.CreateObjectSet<WebsiteUpload>("WebsiteUploads");
                }
                return _WebsiteUploads;
            }
        }
        private ObjectSet<WebsiteUpload> _WebsiteUploads;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CourseLists EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourseLists(CourseList courseList)
        {
            base.AddObject("CourseLists", courseList);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EnrolLists EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEnrolLists(EnrolList enrolList)
        {
            base.AddObject("EnrolLists", enrolList);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WebsiteUploads EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWebsiteUploads(WebsiteUpload websiteUpload)
        {
            base.AddObject("WebsiteUploads", websiteUpload);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ASPNETDBModel", Name="CourseList")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CourseList : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CourseList object.
        /// </summary>
        /// <param name="courseID">Initial value of the CourseID property.</param>
        /// <param name="courseName">Initial value of the CourseName property.</param>
        public static CourseList CreateCourseList(global::System.Int32 courseID, global::System.String courseName)
        {
            CourseList courseList = new CourseList();
            courseList.CourseID = courseID;
            courseList.CourseName = courseName;
            return courseList;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CourseID
        {
            get
            {
                return _CourseID;
            }
            set
            {
                if (_CourseID != value)
                {
                    OnCourseIDChanging(value);
                    ReportPropertyChanging("CourseID");
                    _CourseID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CourseID");
                    OnCourseIDChanged();
                }
            }
        }
        private global::System.Int32 _CourseID;
        partial void OnCourseIDChanging(global::System.Int32 value);
        partial void OnCourseIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                OnCourseNameChanging(value);
                ReportPropertyChanging("CourseName");
                _CourseName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CourseName");
                OnCourseNameChanged();
            }
        }
        private global::System.String _CourseName;
        partial void OnCourseNameChanging(global::System.String value);
        partial void OnCourseNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CourseStartDate
        {
            get
            {
                return _CourseStartDate;
            }
            set
            {
                OnCourseStartDateChanging(value);
                ReportPropertyChanging("CourseStartDate");
                _CourseStartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CourseStartDate");
                OnCourseStartDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _CourseStartDate;
        partial void OnCourseStartDateChanging(Nullable<global::System.DateTime> value);
        partial void OnCourseStartDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CourseEndDate
        {
            get
            {
                return _CourseEndDate;
            }
            set
            {
                OnCourseEndDateChanging(value);
                ReportPropertyChanging("CourseEndDate");
                _CourseEndDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CourseEndDate");
                OnCourseEndDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _CourseEndDate;
        partial void OnCourseEndDateChanging(Nullable<global::System.DateTime> value);
        partial void OnCourseEndDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CourseDescription
        {
            get
            {
                return _CourseDescription;
            }
            set
            {
                OnCourseDescriptionChanging(value);
                ReportPropertyChanging("CourseDescription");
                _CourseDescription = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CourseDescription");
                OnCourseDescriptionChanged();
            }
        }
        private global::System.String _CourseDescription;
        partial void OnCourseDescriptionChanging(global::System.String value);
        partial void OnCourseDescriptionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ASPNETDBModel", Name="EnrolList")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EnrolList : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EnrolList object.
        /// </summary>
        /// <param name="enrolID">Initial value of the EnrolID property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="courseName">Initial value of the CourseName property.</param>
        /// <param name="enquiryDate">Initial value of the EnquiryDate property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        public static EnrolList CreateEnrolList(global::System.Int32 enrolID, global::System.String firstName, global::System.String lastName, global::System.String courseName, global::System.DateTime enquiryDate, global::System.String email)
        {
            EnrolList enrolList = new EnrolList();
            enrolList.EnrolID = enrolID;
            enrolList.FirstName = firstName;
            enrolList.LastName = lastName;
            enrolList.CourseName = courseName;
            enrolList.EnquiryDate = enquiryDate;
            enrolList.Email = email;
            return enrolList;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EnrolID
        {
            get
            {
                return _EnrolID;
            }
            set
            {
                if (_EnrolID != value)
                {
                    OnEnrolIDChanging(value);
                    ReportPropertyChanging("EnrolID");
                    _EnrolID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EnrolID");
                    OnEnrolIDChanged();
                }
            }
        }
        private global::System.Int32 _EnrolID;
        partial void OnEnrolIDChanging(global::System.Int32 value);
        partial void OnEnrolIDChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                OnCourseNameChanging(value);
                ReportPropertyChanging("CourseName");
                _CourseName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CourseName");
                OnCourseNameChanged();
            }
        }
        private global::System.String _CourseName;
        partial void OnCourseNameChanging(global::System.String value);
        partial void OnCourseNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EnquiryDate
        {
            get
            {
                return _EnquiryDate;
            }
            set
            {
                OnEnquiryDateChanging(value);
                ReportPropertyChanging("EnquiryDate");
                _EnquiryDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EnquiryDate");
                OnEnquiryDateChanged();
            }
        }
        private global::System.DateTime _EnquiryDate;
        partial void OnEnquiryDateChanging(global::System.DateTime value);
        partial void OnEnquiryDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
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
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ASPNETDBModel", Name="WebsiteUpload")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WebsiteUpload : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WebsiteUpload object.
        /// </summary>
        /// <param name="materialID">Initial value of the MaterialID property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="file">Initial value of the File property.</param>
        public static WebsiteUpload CreateWebsiteUpload(global::System.Int32 materialID, global::System.String title, global::System.String description, global::System.String file)
        {
            WebsiteUpload websiteUpload = new WebsiteUpload();
            websiteUpload.MaterialID = materialID;
            websiteUpload.Title = title;
            websiteUpload.Description = description;
            websiteUpload.File = file;
            return websiteUpload;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MaterialID
        {
            get
            {
                return _MaterialID;
            }
            set
            {
                if (_MaterialID != value)
                {
                    OnMaterialIDChanging(value);
                    ReportPropertyChanging("MaterialID");
                    _MaterialID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MaterialID");
                    OnMaterialIDChanged();
                }
            }
        }
        private global::System.Int32 _MaterialID;
        partial void OnMaterialIDChanging(global::System.Int32 value);
        partial void OnMaterialIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String File
        {
            get
            {
                return _File;
            }
            set
            {
                OnFileChanging(value);
                ReportPropertyChanging("File");
                _File = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("File");
                OnFileChanged();
            }
        }
        private global::System.String _File;
        partial void OnFileChanging(global::System.String value);
        partial void OnFileChanged();

        #endregion

    
    }

    #endregion

    
}
