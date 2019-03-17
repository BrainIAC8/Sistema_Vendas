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

namespace system.dal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sales_System")]
	public partial class systemDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertSubcategory(Subcategory instance);
    partial void UpdateSubcategory(Subcategory instance);
    partial void DeleteSubcategory(Subcategory instance);
    #endregion
		
		public systemDataContext() : 
				base(global::system.dal.Properties.Settings.Default.Sales_SystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public systemDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public systemDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Subcategory> Subcategories
		{
			get
			{
				return this.GetTable<Subcategory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdCategory;
		
		private string _Description;
		
		private string _SubCategory;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCategoryChanging(int value);
    partial void OnIdCategoryChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSubCategoryChanging(string value);

       

        partial void OnSubCategoryChanged();
    #endregion
		
		public Category()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_category", Storage="_IdCategory", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdCategory
		{
			get
			{
				return this._IdCategory;
			}
			set
			{
				if ((this._IdCategory != value))
				{
					this.OnIdCategoryChanging(value);
					this.SendPropertyChanging();
					this._IdCategory = value;
					this.SendPropertyChanged("IdCategory");
					this.OnIdCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="description_category", Storage="_Description", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="sub_category", Storage="_SubCategory", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SubCategory
		{
			get
			{
				return this._SubCategory;
			}
			set
			{
				if ((this._SubCategory != value))
				{
					this.OnSubCategoryChanging(value);
					this.SendPropertyChanging();
					this._SubCategory = value;
					this.SendPropertyChanged("SubCategory");
					this.OnSubCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_category_tb_product", Storage="_Products", ThisKey="IdCategory", OtherKey="IdCategory")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdProduct;
		
		private string _Description;
		
		private decimal _Price;
		
		private int _IdCategory;
		
		private int _IdProvider;
		
		private System.Nullable<int> _IdSubCategory;
		
		private int _REF;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdProductChanging(int value);
    partial void OnIdProductChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnIdCategoryChanging(int value);
    partial void OnIdCategoryChanged();
    partial void OnIdProviderChanging(int value);
    partial void OnIdProviderChanged();
    partial void OnIdSubCategoryChanging(System.Nullable<int> value);
    partial void OnIdSubCategoryChanged();
    partial void OnREFChanging(int value);
    partial void OnREFChanged();
    #endregion
		
		public Product()
		{
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_product", Storage="_IdProduct", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdProduct
		{
			get
			{
				return this._IdProduct;
			}
			set
			{
				if ((this._IdProduct != value))
				{
					this.OnIdProductChanging(value);
					this.SendPropertyChanging();
					this._IdProduct = value;
					this.SendPropertyChanged("IdProduct");
					this.OnIdProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="description_product", Storage="_Description", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="price", Storage="_Price", DbType="Decimal(25,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_category", Storage="_IdCategory", DbType="Int NOT NULL")]
		public int IdCategory
		{
			get
			{
				return this._IdCategory;
			}
			set
			{
				if ((this._IdCategory != value))
				{
					this.OnIdCategoryChanging(value);
					this.SendPropertyChanging();
					this._IdCategory = value;
					this.SendPropertyChanged("IdCategory");
					this.OnIdCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_provider", Storage="_IdProvider", DbType="Int NOT NULL")]
		public int IdProvider
		{
			get
			{
				return this._IdProvider;
			}
			set
			{
				if ((this._IdProvider != value))
				{
					this.OnIdProviderChanging(value);
					this.SendPropertyChanging();
					this._IdProvider = value;
					this.SendPropertyChanged("IdProvider");
					this.OnIdProviderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_sub_category", Storage="_IdSubCategory", DbType="Int")]
		public System.Nullable<int> IdSubCategory
		{
			get
			{
				return this._IdSubCategory;
			}
			set
			{
				if ((this._IdSubCategory != value))
				{
					this.OnIdSubCategoryChanging(value);
					this.SendPropertyChanging();
					this._IdSubCategory = value;
					this.SendPropertyChanged("IdSubCategory");
					this.OnIdSubCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REF", DbType="Int NOT NULL")]
		public int REF
		{
			get
			{
				return this._REF;
			}
			set
			{
				if ((this._REF != value))
				{
					this.OnREFChanging(value);
					this.SendPropertyChanging();
					this._REF = value;
					this.SendPropertyChanged("REF");
					this.OnREFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_category_tb_product", Storage="_Category", ThisKey="IdCategory", OtherKey="IdCategory", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._IdCategory = value.IdCategory;
					}
					else
					{
						this._IdCategory = default(int);
					}
					this.SendPropertyChanged("Category");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_subcategory")]
	public partial class Subcategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_subcategory;
		
		private string _subcategory_description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_subcategoryChanging(int value);
    partial void Onid_subcategoryChanged();
    partial void Onsubcategory_descriptionChanging(string value);
    partial void Onsubcategory_descriptionChanged();
    #endregion
		
		public Subcategory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_subcategory", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_subcategory
		{
			get
			{
				return this._id_subcategory;
			}
			set
			{
				if ((this._id_subcategory != value))
				{
					this.Onid_subcategoryChanging(value);
					this.SendPropertyChanging();
					this._id_subcategory = value;
					this.SendPropertyChanged("id_subcategory");
					this.Onid_subcategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subcategory_description", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string subcategory_description
		{
			get
			{
				return this._subcategory_description;
			}
			set
			{
				if ((this._subcategory_description != value))
				{
					this.Onsubcategory_descriptionChanging(value);
					this.SendPropertyChanging();
					this._subcategory_description = value;
					this.SendPropertyChanged("subcategory_description");
					this.Onsubcategory_descriptionChanged();
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
}
#pragma warning restore 1591
