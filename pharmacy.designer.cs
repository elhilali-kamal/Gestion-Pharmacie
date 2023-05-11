﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Control_2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="pharmacy")]
	public partial class pharmacyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmedicine(medicine instance);
    partial void Updatemedicine(medicine instance);
    partial void Deletemedicine(medicine instance);
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    partial void InsertordersDetail(ordersDetail instance);
    partial void UpdateordersDetail(ordersDetail instance);
    partial void DeleteordersDetail(ordersDetail instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    #endregion
		
		public pharmacyDataContext() : 
				base(global::Projet_Control_2.Properties.Settings.Default.pharmacyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public pharmacyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<medicine> medicines
		{
			get
			{
				return this.GetTable<medicine>();
			}
		}
		
		public System.Data.Linq.Table<client> clients
		{
			get
			{
				return this.GetTable<client>();
			}
		}
		
		public System.Data.Linq.Table<ordersDetail> ordersDetails
		{
			get
			{
				return this.GetTable<ordersDetail>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.medicine")]
	public partial class medicine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _medicineid;
		
		private string _title;
		
		private string _description;
		
		private decimal _price;
		
		private string _require;
		
		private string _quantity;
		
		private System.Data.Linq.Binary _picture;
		
		private EntitySet<ordersDetail> _ordersDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmedicineidChanging(int value);
    partial void OnmedicineidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnrequireChanging(string value);
    partial void OnrequireChanged();
    partial void OnquantityChanging(string value);
    partial void OnquantityChanged();
    partial void OnpictureChanging(System.Data.Linq.Binary value);
    partial void OnpictureChanged();
    #endregion
		
		public medicine()
		{
			this._ordersDetails = new EntitySet<ordersDetail>(new Action<ordersDetail>(this.attach_ordersDetails), new Action<ordersDetail>(this.detach_ordersDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_medicineid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int medicineid
		{
			get
			{
				return this._medicineid;
			}
			set
			{
				if ((this._medicineid != value))
				{
					this.OnmedicineidChanging(value);
					this.SendPropertyChanging();
					this._medicineid = value;
					this.SendPropertyChanged("medicineid");
					this.OnmedicineidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_require", DbType="VarChar(10)")]
		public string require
		{
			get
			{
				return this._require;
			}
			set
			{
				if ((this._require != value))
				{
					this.OnrequireChanging(value);
					this.SendPropertyChanging();
					this._require = value;
					this.SendPropertyChanged("require");
					this.OnrequireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="VarChar(10)")]
		public string quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="medicine_ordersDetail", Storage="_ordersDetails", ThisKey="medicineid", OtherKey="medicineid")]
		public EntitySet<ordersDetail> ordersDetails
		{
			get
			{
				return this._ordersDetails;
			}
			set
			{
				this._ordersDetails.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ordersDetails(ordersDetail entity)
		{
			this.SendPropertyChanging();
			entity.medicine = this;
		}
		
		private void detach_ordersDetails(ordersDetail entity)
		{
			this.SendPropertyChanging();
			entity.medicine = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _clientid;
		
		private string _firstname;
		
		private string _lastname;
		
		private System.Nullable<int> _age;
		
		private string _adress;
		
		private string _phone;
		
		private string _username;
		
		private string _password;
		
		private EntitySet<order> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnclientidChanging(int value);
    partial void OnclientidChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OnadressChanging(string value);
    partial void OnadressChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public client()
		{
			this._orders = new EntitySet<order>(new Action<order>(this.attach_orders), new Action<order>(this.detach_orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clientid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int clientid
		{
			get
			{
				return this._clientid;
			}
			set
			{
				if ((this._clientid != value))
				{
					this.OnclientidChanging(value);
					this.SendPropertyChanging();
					this._clientid = value;
					this.SendPropertyChanged("clientid");
					this.OnclientidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="VarChar(30)")]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(30)")]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
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
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adress", DbType="VarChar(100)")]
		public string adress
		{
			get
			{
				return this._adress;
			}
			set
			{
				if ((this._adress != value))
				{
					this.OnadressChanging(value);
					this.SendPropertyChanging();
					this._adress = value;
					this.SendPropertyChanged("adress");
					this.OnadressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(30)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_order", Storage="_orders", ThisKey="clientid", OtherKey="clientid")]
		public EntitySet<order> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				this._orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.client = this;
		}
		
		private void detach_orders(order entity)
		{
			this.SendPropertyChanging();
			entity.client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ordersDetails")]
	public partial class ordersDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _orderid;
		
		private int _medicineid;
		
		private string _title;
		
		private string _quantity;
		
		private System.Nullable<decimal> _price;
		
		private EntityRef<medicine> _medicine;
		
		private EntityRef<order> _order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnorderidChanging(int value);
    partial void OnorderidChanged();
    partial void OnmedicineidChanging(int value);
    partial void OnmedicineidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnquantityChanging(string value);
    partial void OnquantityChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    #endregion
		
		public ordersDetail()
		{
			this._medicine = default(EntityRef<medicine>);
			this._order = default(EntityRef<order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					if (this._order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_medicineid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int medicineid
		{
			get
			{
				return this._medicineid;
			}
			set
			{
				if ((this._medicineid != value))
				{
					if (this._medicine.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmedicineidChanging(value);
					this.SendPropertyChanging();
					this._medicineid = value;
					this.SendPropertyChanged("medicineid");
					this.OnmedicineidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="VarChar(15)")]
		public string quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="medicine_ordersDetail", Storage="_medicine", ThisKey="medicineid", OtherKey="medicineid", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public medicine medicine
		{
			get
			{
				return this._medicine.Entity;
			}
			set
			{
				medicine previousValue = this._medicine.Entity;
				if (((previousValue != value) 
							|| (this._medicine.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._medicine.Entity = null;
						previousValue.ordersDetails.Remove(this);
					}
					this._medicine.Entity = value;
					if ((value != null))
					{
						value.ordersDetails.Add(this);
						this._medicineid = value.medicineid;
					}
					else
					{
						this._medicineid = default(int);
					}
					this.SendPropertyChanged("medicine");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_ordersDetail", Storage="_order", ThisKey="orderid", OtherKey="orderid", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public order order
		{
			get
			{
				return this._order.Entity;
			}
			set
			{
				order previousValue = this._order.Entity;
				if (((previousValue != value) 
							|| (this._order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._order.Entity = null;
						previousValue.ordersDetails.Remove(this);
					}
					this._order.Entity = value;
					if ((value != null))
					{
						value.ordersDetails.Add(this);
						this._orderid = value.orderid;
					}
					else
					{
						this._orderid = default(int);
					}
					this.SendPropertyChanged("order");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderid;
		
		private System.Nullable<int> _clientid;
		
		private System.Nullable<decimal> _totalprice;
		
		private string _status;
		
		private EntitySet<ordersDetail> _ordersDetails;
		
		private EntityRef<client> _client;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderidChanging(int value);
    partial void OnorderidChanged();
    partial void OnclientidChanging(System.Nullable<int> value);
    partial void OnclientidChanged();
    partial void OntotalpriceChanging(System.Nullable<decimal> value);
    partial void OntotalpriceChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public order()
		{
			this._ordersDetails = new EntitySet<ordersDetail>(new Action<ordersDetail>(this.attach_ordersDetails), new Action<ordersDetail>(this.detach_ordersDetails));
			this._client = default(EntityRef<client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderid
		{
			get
			{
				return this._orderid;
			}
			set
			{
				if ((this._orderid != value))
				{
					this.OnorderidChanging(value);
					this.SendPropertyChanging();
					this._orderid = value;
					this.SendPropertyChanged("orderid");
					this.OnorderidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clientid", DbType="Int")]
		public System.Nullable<int> clientid
		{
			get
			{
				return this._clientid;
			}
			set
			{
				if ((this._clientid != value))
				{
					if (this._client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnclientidChanging(value);
					this.SendPropertyChanging();
					this._clientid = value;
					this.SendPropertyChanged("clientid");
					this.OnclientidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalprice", DbType="Money")]
		public System.Nullable<decimal> totalprice
		{
			get
			{
				return this._totalprice;
			}
			set
			{
				if ((this._totalprice != value))
				{
					this.OntotalpriceChanging(value);
					this.SendPropertyChanging();
					this._totalprice = value;
					this.SendPropertyChanged("totalprice");
					this.OntotalpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(40)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="order_ordersDetail", Storage="_ordersDetails", ThisKey="orderid", OtherKey="orderid")]
		public EntitySet<ordersDetail> ordersDetails
		{
			get
			{
				return this._ordersDetails;
			}
			set
			{
				this._ordersDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_order", Storage="_client", ThisKey="clientid", OtherKey="clientid", IsForeignKey=true, DeleteRule="CASCADE")]
		public client client
		{
			get
			{
				return this._client.Entity;
			}
			set
			{
				client previousValue = this._client.Entity;
				if (((previousValue != value) 
							|| (this._client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._client.Entity = null;
						previousValue.orders.Remove(this);
					}
					this._client.Entity = value;
					if ((value != null))
					{
						value.orders.Add(this);
						this._clientid = value.clientid;
					}
					else
					{
						this._clientid = default(Nullable<int>);
					}
					this.SendPropertyChanged("client");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ordersDetails(ordersDetail entity)
		{
			this.SendPropertyChanging();
			entity.order = this;
		}
		
		private void detach_ordersDetails(ordersDetail entity)
		{
			this.SendPropertyChanging();
			entity.order = null;
		}
	}
}
#pragma warning restore 1591
