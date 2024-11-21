﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MiniPIM")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAtributo(Atributo instance);
    partial void UpdateAtributo(Atributo instance);
    partial void DeleteAtributo(Atributo instance);
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProducto(Producto instance);
    partial void UpdateProducto(Producto instance);
    partial void DeleteProducto(Producto instance);
    partial void InsertProductoCategoria(ProductoCategoria instance);
    partial void UpdateProductoCategoria(ProductoCategoria instance);
    partial void DeleteProductoCategoria(ProductoCategoria instance);
    partial void InsertTipoAtributo(TipoAtributo instance);
    partial void UpdateTipoAtributo(TipoAtributo instance);
    partial void DeleteTipoAtributo(TipoAtributo instance);
    partial void InsertValorAtributo(ValorAtributo instance);
    partial void UpdateValorAtributo(ValorAtributo instance);
    partial void DeleteValorAtributo(ValorAtributo instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplication2.Properties.Settings.Default.MiniPIMConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Atributo> Atributo
		{
			get
			{
				return this.GetTable<Atributo>();
			}
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Producto> Producto
		{
			get
			{
				return this.GetTable<Producto>();
			}
		}
		
		public System.Data.Linq.Table<ProductoCategoria> ProductoCategoria
		{
			get
			{
				return this.GetTable<ProductoCategoria>();
			}
		}
		
		public System.Data.Linq.Table<TipoAtributo> TipoAtributo
		{
			get
			{
				return this.GetTable<TipoAtributo>();
			}
		}
		
		public System.Data.Linq.Table<ValorAtributo> ValorAtributo
		{
			get
			{
				return this.GetTable<ValorAtributo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Atributo")]
	public partial class Atributo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private int _tipo;
		
		private EntitySet<ValorAtributo> _ValorAtributo;
		
		private EntityRef<TipoAtributo> _TipoAtributo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OntipoChanging(int value);
    partial void OntipoChanged();
    #endregion
		
		public Atributo()
		{
			this._ValorAtributo = new EntitySet<ValorAtributo>(new Action<ValorAtributo>(this.attach_ValorAtributo), new Action<ValorAtributo>(this.detach_ValorAtributo));
			this._TipoAtributo = default(EntityRef<TipoAtributo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="Int NOT NULL")]
		public int tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					if (this._TipoAtributo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Atributo_ValorAtributo", Storage="_ValorAtributo", ThisKey="id", OtherKey="atributo_id")]
		public EntitySet<ValorAtributo> ValorAtributo
		{
			get
			{
				return this._ValorAtributo;
			}
			set
			{
				this._ValorAtributo.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoAtributo_Atributo", Storage="_TipoAtributo", ThisKey="tipo", OtherKey="id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public TipoAtributo TipoAtributo
		{
			get
			{
				return this._TipoAtributo.Entity;
			}
			set
			{
				TipoAtributo previousValue = this._TipoAtributo.Entity;
				if (((previousValue != value) 
							|| (this._TipoAtributo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TipoAtributo.Entity = null;
						previousValue.Atributo.Remove(this);
					}
					this._TipoAtributo.Entity = value;
					if ((value != null))
					{
						value.Atributo.Add(this);
						this._tipo = value.id;
					}
					else
					{
						this._tipo = default(int);
					}
					this.SendPropertyChanged("TipoAtributo");
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
		
		private void attach_ValorAtributo(ValorAtributo entity)
		{
			this.SendPropertyChanging();
			entity.Atributo = this;
		}
		
		private void detach_ValorAtributo(ValorAtributo entity)
		{
			this.SendPropertyChanging();
			entity.Atributo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private EntitySet<ProductoCategoria> _ProductoCategoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public Categoria()
		{
			this._ProductoCategoria = new EntitySet<ProductoCategoria>(new Action<ProductoCategoria>(this.attach_ProductoCategoria), new Action<ProductoCategoria>(this.detach_ProductoCategoria));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_ProductoCategoria", Storage="_ProductoCategoria", ThisKey="id", OtherKey="categoria_id")]
		public EntitySet<ProductoCategoria> ProductoCategoria
		{
			get
			{
				return this._ProductoCategoria;
			}
			set
			{
				this._ProductoCategoria.Assign(value);
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
		
		private void attach_ProductoCategoria(ProductoCategoria entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_ProductoCategoria(ProductoCategoria entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producto")]
	public partial class Producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Thumbnail;
		
		private string _SKU;
		
		private string _Label;
		
		private string _GTIN;
		
		private EntitySet<ProductoCategoria> _ProductoCategoria;
		
		private EntitySet<ValorAtributo> _ValorAtributo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnThumbnailChanging(string value);
    partial void OnThumbnailChanged();
    partial void OnSKUChanging(string value);
    partial void OnSKUChanged();
    partial void OnLabelChanging(string value);
    partial void OnLabelChanged();
    partial void OnGTINChanging(string value);
    partial void OnGTINChanged();
    #endregion
		
		public Producto()
		{
			this._ProductoCategoria = new EntitySet<ProductoCategoria>(new Action<ProductoCategoria>(this.attach_ProductoCategoria), new Action<ProductoCategoria>(this.detach_ProductoCategoria));
			this._ValorAtributo = new EntitySet<ValorAtributo>(new Action<ValorAtributo>(this.attach_ValorAtributo), new Action<ValorAtributo>(this.detach_ValorAtributo));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thumbnail", DbType="NVarChar(255)")]
		public string Thumbnail
		{
			get
			{
				return this._Thumbnail;
			}
			set
			{
				if ((this._Thumbnail != value))
				{
					this.OnThumbnailChanging(value);
					this.SendPropertyChanging();
					this._Thumbnail = value;
					this.SendPropertyChanged("Thumbnail");
					this.OnThumbnailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this.OnSKUChanging(value);
					this.SendPropertyChanging();
					this._SKU = value;
					this.SendPropertyChanged("SKU");
					this.OnSKUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Label", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Label
		{
			get
			{
				return this._Label;
			}
			set
			{
				if ((this._Label != value))
				{
					this.OnLabelChanging(value);
					this.SendPropertyChanging();
					this._Label = value;
					this.SendPropertyChanged("Label");
					this.OnLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GTIN", DbType="Char(14) NOT NULL", CanBeNull=false)]
		public string GTIN
		{
			get
			{
				return this._GTIN;
			}
			set
			{
				if ((this._GTIN != value))
				{
					this.OnGTINChanging(value);
					this.SendPropertyChanging();
					this._GTIN = value;
					this.SendPropertyChanged("GTIN");
					this.OnGTINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_ProductoCategoria", Storage="_ProductoCategoria", ThisKey="SKU", OtherKey="producto_SKU")]
		public EntitySet<ProductoCategoria> ProductoCategoria
		{
			get
			{
				return this._ProductoCategoria;
			}
			set
			{
				this._ProductoCategoria.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_ValorAtributo", Storage="_ValorAtributo", ThisKey="SKU", OtherKey="producto_SKU")]
		public EntitySet<ValorAtributo> ValorAtributo
		{
			get
			{
				return this._ValorAtributo;
			}
			set
			{
				this._ValorAtributo.Assign(value);
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
		
		private void attach_ProductoCategoria(ProductoCategoria entity)
		{
			this.SendPropertyChanging();
			entity.Producto = this;
		}
		
		private void detach_ProductoCategoria(ProductoCategoria entity)
		{
			this.SendPropertyChanging();
			entity.Producto = null;
		}
		
		private void attach_ValorAtributo(ValorAtributo entity)
		{
			this.SendPropertyChanging();
			entity.Producto = this;
		}
		
		private void detach_ValorAtributo(ValorAtributo entity)
		{
			this.SendPropertyChanging();
			entity.Producto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductoCategoria")]
	public partial class ProductoCategoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _producto_SKU;
		
		private int _categoria_id;
		
		private EntityRef<Categoria> _Categoria;
		
		private EntityRef<Producto> _Producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onproducto_SKUChanging(string value);
    partial void Onproducto_SKUChanged();
    partial void Oncategoria_idChanging(int value);
    partial void Oncategoria_idChanged();
    #endregion
		
		public ProductoCategoria()
		{
			this._Categoria = default(EntityRef<Categoria>);
			this._Producto = default(EntityRef<Producto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producto_SKU", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string producto_SKU
		{
			get
			{
				return this._producto_SKU;
			}
			set
			{
				if ((this._producto_SKU != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproducto_SKUChanging(value);
					this.SendPropertyChanging();
					this._producto_SKU = value;
					this.SendPropertyChanged("producto_SKU");
					this.Onproducto_SKUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoria_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int categoria_id
		{
			get
			{
				return this._categoria_id;
			}
			set
			{
				if ((this._categoria_id != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncategoria_idChanging(value);
					this.SendPropertyChanging();
					this._categoria_id = value;
					this.SendPropertyChanged("categoria_id");
					this.Oncategoria_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_ProductoCategoria", Storage="_Categoria", ThisKey="categoria_id", OtherKey="id", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.ProductoCategoria.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.ProductoCategoria.Add(this);
						this._categoria_id = value.id;
					}
					else
					{
						this._categoria_id = default(int);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_ProductoCategoria", Storage="_Producto", ThisKey="producto_SKU", OtherKey="SKU", IsForeignKey=true)]
		public Producto Producto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				Producto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.ProductoCategoria.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.ProductoCategoria.Add(this);
						this._producto_SKU = value.SKU;
					}
					else
					{
						this._producto_SKU = default(string);
					}
					this.SendPropertyChanged("Producto");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TipoAtributo")]
	public partial class TipoAtributo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private EntitySet<Atributo> _Atributo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public TipoAtributo()
		{
			this._Atributo = new EntitySet<Atributo>(new Action<Atributo>(this.attach_Atributo), new Action<Atributo>(this.detach_Atributo));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoAtributo_Atributo", Storage="_Atributo", ThisKey="id", OtherKey="tipo")]
		public EntitySet<Atributo> Atributo
		{
			get
			{
				return this._Atributo;
			}
			set
			{
				this._Atributo.Assign(value);
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
		
		private void attach_Atributo(Atributo entity)
		{
			this.SendPropertyChanging();
			entity.TipoAtributo = this;
		}
		
		private void detach_Atributo(Atributo entity)
		{
			this.SendPropertyChanging();
			entity.TipoAtributo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ValorAtributo")]
	public partial class ValorAtributo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _valor;
		
		private int _atributo_id;
		
		private string _producto_SKU;
		
		private EntityRef<Atributo> _Atributo;
		
		private EntityRef<Producto> _Producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnvalorChanging(string value);
    partial void OnvalorChanged();
    partial void Onatributo_idChanging(int value);
    partial void Onatributo_idChanged();
    partial void Onproducto_SKUChanging(string value);
    partial void Onproducto_SKUChanged();
    #endregion
		
		public ValorAtributo()
		{
			this._Atributo = default(EntityRef<Atributo>);
			this._Producto = default(EntityRef<Producto>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((this._valor != value))
				{
					this.OnvalorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("valor");
					this.OnvalorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_atributo_id", DbType="Int NOT NULL")]
		public int atributo_id
		{
			get
			{
				return this._atributo_id;
			}
			set
			{
				if ((this._atributo_id != value))
				{
					if (this._Atributo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onatributo_idChanging(value);
					this.SendPropertyChanging();
					this._atributo_id = value;
					this.SendPropertyChanged("atributo_id");
					this.Onatributo_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_producto_SKU", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string producto_SKU
		{
			get
			{
				return this._producto_SKU;
			}
			set
			{
				if ((this._producto_SKU != value))
				{
					if (this._Producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproducto_SKUChanging(value);
					this.SendPropertyChanging();
					this._producto_SKU = value;
					this.SendPropertyChanged("producto_SKU");
					this.Onproducto_SKUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Atributo_ValorAtributo", Storage="_Atributo", ThisKey="atributo_id", OtherKey="id", IsForeignKey=true)]
		public Atributo Atributo
		{
			get
			{
				return this._Atributo.Entity;
			}
			set
			{
				Atributo previousValue = this._Atributo.Entity;
				if (((previousValue != value) 
							|| (this._Atributo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Atributo.Entity = null;
						previousValue.ValorAtributo.Remove(this);
					}
					this._Atributo.Entity = value;
					if ((value != null))
					{
						value.ValorAtributo.Add(this);
						this._atributo_id = value.id;
					}
					else
					{
						this._atributo_id = default(int);
					}
					this.SendPropertyChanged("Atributo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producto_ValorAtributo", Storage="_Producto", ThisKey="producto_SKU", OtherKey="SKU", IsForeignKey=true)]
		public Producto Producto
		{
			get
			{
				return this._Producto.Entity;
			}
			set
			{
				Producto previousValue = this._Producto.Entity;
				if (((previousValue != value) 
							|| (this._Producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producto.Entity = null;
						previousValue.ValorAtributo.Remove(this);
					}
					this._Producto.Entity = value;
					if ((value != null))
					{
						value.ValorAtributo.Add(this);
						this._producto_SKU = value.SKU;
					}
					else
					{
						this._producto_SKU = default(string);
					}
					this.SendPropertyChanged("Producto");
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
