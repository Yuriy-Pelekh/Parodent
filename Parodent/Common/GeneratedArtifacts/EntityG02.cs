

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Customer : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Customer entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Customer()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Customer(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Customer> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Customer.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string FirstName
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.FirstName);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.FirstName, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FirstName_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string MiddleName
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.MiddleName);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.MiddleName, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void MiddleName_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void MiddleName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void MiddleName_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string LastName
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.LastName);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.LastName, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LastName_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LastName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LastName_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string FullName
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.FullName);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FullName_Compute(ref string result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void FullName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Invoice> Invoices
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Invoices);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Invoice> InvoicesQuery
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetQuery(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Invoices);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Customer,
                global::LightSwitchApplication.Customer.DetailsClass,
                global::LightSwitchApplication.Customer.DetailsClass.IImplementation,
                global::LightSwitchApplication.Customer.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>.Entry
                __CustomerEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>.Entry(
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_CreateNew,
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_Created,
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Customer __Customer_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Customer> es)
            {
                return new global::LightSwitchApplication.Customer(es);
            }
            private static void __Customer_Created(global::LightSwitchApplication.Customer e)
            {
                e.Customer_Created();
            }
            private static bool __Customer_AllowSaveWithErrors(global::LightSwitchApplication.Customer e)
            {
                bool result = false;
                e.Customer_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Customer.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> FirstName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.FirstName) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> MiddleName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.MiddleName) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> LastName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.LastName) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> FullName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.FullName) as global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice> Invoices
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Invoices) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string FirstName { get; set; }
                new string MiddleName { get; set; }
                new string LastName { get; set; }
                new global::System.Collections.IEnumerable Invoices { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    FirstName = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "FirstName",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FirstName_OnValueChanged);
                private static void _FirstName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._FirstName, sf);
                }
                private static bool _FirstName_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.FirstName_IsReadOnly(ref result);
                    return result;
                }
                private static void _FirstName_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.FirstName_Validate(r);
                }
                private static string _FirstName_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.FirstName;
                }
                private static void _FirstName_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, string v)
                {
                    d.ImplementationEntity.FirstName = v;
                }
                private static void _FirstName_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.FirstName_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    MiddleName = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "MiddleName",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._MiddleName_OnValueChanged);
                private static void _MiddleName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._MiddleName, sf);
                }
                private static bool _MiddleName_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.MiddleName_IsReadOnly(ref result);
                    return result;
                }
                private static void _MiddleName_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.MiddleName_Validate(r);
                }
                private static string _MiddleName_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.MiddleName;
                }
                private static void _MiddleName_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, string v)
                {
                    d.ImplementationEntity.MiddleName = v;
                }
                private static void _MiddleName_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.MiddleName_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    LastName = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "LastName",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._LastName_OnValueChanged);
                private static void _LastName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._LastName, sf);
                }
                private static bool _LastName_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.LastName_IsReadOnly(ref result);
                    return result;
                }
                private static void _LastName_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.LastName_Validate(r);
                }
                private static string _LastName_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.LastName;
                }
                private static void _LastName_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, string v)
                {
                    d.ImplementationEntity.LastName = v;
                }
                private static void _LastName_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.LastName_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    FullName = new global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "FullName",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FullName_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FullName_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._FullName_ComputeValue);
                private static void _FullName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._FullName, sf);
                }
                private static void _FullName_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.FullName_Validate(r);
                }
                private static string _FullName_ComputeValue(global::LightSwitchApplication.Customer e)
                {
                    string value = default(string);
                    e.FullName_Compute(ref value);
                    return value;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice>.Entry
                    Invoices = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice>.Entry(
                        "Invoices",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Invoices_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Invoices_GetReferencedEntities,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Invoices_GetEntityCollection);
                private static void _Invoices_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Invoices, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Invoice> _Invoices_GetReferencedEntities(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Invoice, global::LightSwitchApplication.Invoice.DetailsClass>(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Invoices, ref d._Invoices);
                }
                private static global::System.Collections.IEnumerable _Invoices_GetEntityCollection(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Invoices;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _FirstName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _MiddleName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _LastName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityComputedProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _FullName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Invoice>.Data _Invoices;
            
        }
    
        #endregion
    }
    
    #endregion
}
