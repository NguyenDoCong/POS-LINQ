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

namespace Cafe_236
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="POS")]
	public partial class _236DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCongThuc(CongThuc instance);
    partial void UpdateCongThuc(CongThuc instance);
    partial void DeleteCongThuc(CongThuc instance);
    partial void InsertSLDoUong(SLDoUong instance);
    partial void UpdateSLDoUong(SLDoUong instance);
    partial void DeleteSLDoUong(SLDoUong instance);
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertDoUong(QLDoUong instance);
    partial void UpdateDoUong(QLDoUong instance);
    partial void DeleteDoUong(QLDoUong instance);
    partial void InsertNguyenLieu(NguyenLieu instance);
    partial void UpdateNguyenLieu(NguyenLieu instance);
    partial void DeleteNguyenLieu(NguyenLieu instance);
    partial void InsertNhap(Nhap instance);
    partial void UpdateNhap(Nhap instance);
    partial void DeleteNhap(Nhap instance);
    #endregion
		
		public _236DataContext() : 
				base(global::Cafe_236.Properties.Settings.Default.POSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public _236DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _236DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _236DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _236DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CongThuc> CongThucs
		{
			get
			{
				return this.GetTable<CongThuc>();
			}
		}
		
		public System.Data.Linq.Table<SLDoUong> SLDoUongs
		{
			get
			{
				return this.GetTable<SLDoUong>();
			}
		}
		
		public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<QLDoUong> DoUongs
		{
			get
			{
				return this.GetTable<QLDoUong>();
			}
		}
		
		public System.Data.Linq.Table<NguyenLieu> NguyenLieus
		{
			get
			{
				return this.GetTable<NguyenLieu>();
			}
		}
		
		public System.Data.Linq.Table<Nhap> Nhaps
		{
			get
			{
				return this.GetTable<Nhap>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CongThuc")]
	public partial class CongThuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CongThucID;
		
		private System.Nullable<int> _DoUongID;
		
		private System.Nullable<int> _NguyenLieuID;
		
		private System.Nullable<int> _SL;
		
		private EntityRef<QLDoUong> _DoUong;
		
		private EntityRef<NguyenLieu> _NguyenLieu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCongThucIDChanging(int value);
    partial void OnCongThucIDChanged();
    partial void OnDoUongIDChanging(System.Nullable<int> value);
    partial void OnDoUongIDChanged();
    partial void OnNguyenLieuIDChanging(System.Nullable<int> value);
    partial void OnNguyenLieuIDChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    #endregion
		
		public CongThuc()
		{
			this._DoUong = default(EntityRef<QLDoUong>);
			this._NguyenLieu = default(EntityRef<NguyenLieu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongThucID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CongThucID
		{
			get
			{
				return this._CongThucID;
			}
			set
			{
				if ((this._CongThucID != value))
				{
					this.OnCongThucIDChanging(value);
					this.SendPropertyChanging();
					this._CongThucID = value;
					this.SendPropertyChanged("CongThucID");
					this.OnCongThucIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoUongID", DbType="Int")]
		public System.Nullable<int> DoUongID
		{
			get
			{
				return this._DoUongID;
			}
			set
			{
				if ((this._DoUongID != value))
				{
					if (this._DoUong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoUongIDChanging(value);
					this.SendPropertyChanging();
					this._DoUongID = value;
					this.SendPropertyChanged("DoUongID");
					this.OnDoUongIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguyenLieuID", DbType="Int")]
		public System.Nullable<int> NguyenLieuID
		{
			get
			{
				return this._NguyenLieuID;
			}
			set
			{
				if ((this._NguyenLieuID != value))
				{
					if (this._NguyenLieu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNguyenLieuIDChanging(value);
					this.SendPropertyChanging();
					this._NguyenLieuID = value;
					this.SendPropertyChanged("NguyenLieuID");
					this.OnNguyenLieuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_CongThuc", Storage="_DoUong", ThisKey="DoUongID", OtherKey="DoUongID", IsForeignKey=true)]
		public QLDoUong DoUong
		{
			get
			{
				return this._DoUong.Entity;
			}
			set
			{
				QLDoUong previousValue = this._DoUong.Entity;
				if (((previousValue != value) 
							|| (this._DoUong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DoUong.Entity = null;
						previousValue.CongThucs.Remove(this);
					}
					this._DoUong.Entity = value;
					if ((value != null))
					{
						value.CongThucs.Add(this);
						this._DoUongID = value.DoUongID;
					}
					else
					{
						this._DoUongID = default(Nullable<int>);
					}
					this.SendPropertyChanged("DoUong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguyenLieu_CongThuc", Storage="_NguyenLieu", ThisKey="NguyenLieuID", OtherKey="NguyenLieuID", IsForeignKey=true)]
		public NguyenLieu NguyenLieu
		{
			get
			{
				return this._NguyenLieu.Entity;
			}
			set
			{
				NguyenLieu previousValue = this._NguyenLieu.Entity;
				if (((previousValue != value) 
							|| (this._NguyenLieu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NguyenLieu.Entity = null;
						previousValue.CongThucs.Remove(this);
					}
					this._NguyenLieu.Entity = value;
					if ((value != null))
					{
						value.CongThucs.Add(this);
						this._NguyenLieuID = value.NguyenLieuID;
					}
					else
					{
						this._NguyenLieuID = default(Nullable<int>);
					}
					this.SendPropertyChanged("NguyenLieu");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SLDoUong")]
	public partial class SLDoUong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SLDoUongID;
		
		private System.Nullable<int> _DonHangID;
		
		private System.Nullable<int> _DoUongID;
		
		private System.Nullable<int> _SL;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<QLDoUong> _DoUong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSLDoUongIDChanging(int value);
    partial void OnSLDoUongIDChanged();
    partial void OnDonHangIDChanging(System.Nullable<int> value);
    partial void OnDonHangIDChanged();
    partial void OnDoUongIDChanging(System.Nullable<int> value);
    partial void OnDoUongIDChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    #endregion
		
		public SLDoUong()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._DoUong = default(EntityRef<QLDoUong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLDoUongID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SLDoUongID
		{
			get
			{
				return this._SLDoUongID;
			}
			set
			{
				if ((this._SLDoUongID != value))
				{
					this.OnSLDoUongIDChanging(value);
					this.SendPropertyChanging();
					this._SLDoUongID = value;
					this.SendPropertyChanged("SLDoUongID");
					this.OnSLDoUongIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonHangID", DbType="Int")]
		public System.Nullable<int> DonHangID
		{
			get
			{
				return this._DonHangID;
			}
			set
			{
				if ((this._DonHangID != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDonHangIDChanging(value);
					this.SendPropertyChanging();
					this._DonHangID = value;
					this.SendPropertyChanged("DonHangID");
					this.OnDonHangIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoUongID", DbType="Int")]
		public System.Nullable<int> DoUongID
		{
			get
			{
				return this._DoUongID;
			}
			set
			{
				if ((this._DoUongID != value))
				{
					if (this._DoUong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoUongIDChanging(value);
					this.SendPropertyChanging();
					this._DoUongID = value;
					this.SendPropertyChanged("DoUongID");
					this.OnDoUongIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_SLDoUong", Storage="_DonHang", ThisKey="DonHangID", OtherKey="DonHangID", IsForeignKey=true)]
		public DonHang DonHang
		{
			get
			{
				return this._DonHang.Entity;
			}
			set
			{
				DonHang previousValue = this._DonHang.Entity;
				if (((previousValue != value) 
							|| (this._DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonHang.Entity = null;
						previousValue.SLDoUongs.Remove(this);
					}
					this._DonHang.Entity = value;
					if ((value != null))
					{
						value.SLDoUongs.Add(this);
						this._DonHangID = value.DonHangID;
					}
					else
					{
						this._DonHangID = default(Nullable<int>);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_SLDoUong", Storage="_DoUong", ThisKey="DoUongID", OtherKey="DoUongID", IsForeignKey=true)]
		public QLDoUong DoUong
		{
			get
			{
				return this._DoUong.Entity;
			}
			set
			{
				QLDoUong previousValue = this._DoUong.Entity;
				if (((previousValue != value) 
							|| (this._DoUong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DoUong.Entity = null;
						previousValue.SLDoUongs.Remove(this);
					}
					this._DoUong.Entity = value;
					if ((value != null))
					{
						value.SLDoUongs.Add(this);
						this._DoUongID = value.DoUongID;
					}
					else
					{
						this._DoUongID = default(Nullable<int>);
					}
					this.SendPropertyChanged("DoUong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DonHangID;
		
		private System.Nullable<System.DateTime> _Ngay;
		
		private System.Nullable<decimal> _TongSoTien;
		
		private EntitySet<SLDoUong> _SLDoUongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDonHangIDChanging(int value);
    partial void OnDonHangIDChanged();
    partial void OnNgayChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayChanged();
    partial void OnTongSoTienChanging(System.Nullable<decimal> value);
    partial void OnTongSoTienChanged();
    #endregion
		
		public DonHang()
		{
			this._SLDoUongs = new EntitySet<SLDoUong>(new Action<SLDoUong>(this.attach_SLDoUongs), new Action<SLDoUong>(this.detach_SLDoUongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonHangID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DonHangID
		{
			get
			{
				return this._DonHangID;
			}
			set
			{
				if ((this._DonHangID != value))
				{
					this.OnDonHangIDChanging(value);
					this.SendPropertyChanging();
					this._DonHangID = value;
					this.SendPropertyChanged("DonHangID");
					this.OnDonHangIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngay", DbType="Date")]
		public System.Nullable<System.DateTime> Ngay
		{
			get
			{
				return this._Ngay;
			}
			set
			{
				if ((this._Ngay != value))
				{
					this.OnNgayChanging(value);
					this.SendPropertyChanging();
					this._Ngay = value;
					this.SendPropertyChanged("Ngay");
					this.OnNgayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongSoTien", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TongSoTien
		{
			get
			{
				return this._TongSoTien;
			}
			set
			{
				if ((this._TongSoTien != value))
				{
					this.OnTongSoTienChanging(value);
					this.SendPropertyChanging();
					this._TongSoTien = value;
					this.SendPropertyChanged("TongSoTien");
					this.OnTongSoTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_SLDoUong", Storage="_SLDoUongs", ThisKey="DonHangID", OtherKey="DonHangID")]
		public EntitySet<SLDoUong> SLDoUongs
		{
			get
			{
				return this._SLDoUongs;
			}
			set
			{
				this._SLDoUongs.Assign(value);
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
		
		private void attach_SLDoUongs(SLDoUong entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = this;
		}
		
		private void detach_SLDoUongs(SLDoUong entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoUong")]
	public partial class QLDoUong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DoUongID;
		
		private string _TenDoUong;
		
		private System.Nullable<decimal> _Gia;
		
		private string _Loai;
		
		private EntitySet<CongThuc> _CongThucs;
		
		private EntitySet<SLDoUong> _SLDoUongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDoUongIDChanging(int value);
    partial void OnDoUongIDChanged();
    partial void OnTenDoUongChanging(string value);
    partial void OnTenDoUongChanged();
    partial void OnGiaChanging(System.Nullable<decimal> value);
    partial void OnGiaChanged();
    partial void OnLoaiChanging(string value);
    partial void OnLoaiChanged();
    #endregion
		
		public QLDoUong()
		{
			this._CongThucs = new EntitySet<CongThuc>(new Action<CongThuc>(this.attach_CongThucs), new Action<CongThuc>(this.detach_CongThucs));
			this._SLDoUongs = new EntitySet<SLDoUong>(new Action<SLDoUong>(this.attach_SLDoUongs), new Action<SLDoUong>(this.detach_SLDoUongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoUongID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DoUongID
		{
			get
			{
				return this._DoUongID;
			}
			set
			{
				if ((this._DoUongID != value))
				{
					this.OnDoUongIDChanging(value);
					this.SendPropertyChanging();
					this._DoUongID = value;
					this.SendPropertyChanged("DoUongID");
					this.OnDoUongIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDoUong", DbType="NVarChar(50)")]
		public string TenDoUong
		{
			get
			{
				return this._TenDoUong;
			}
			set
			{
				if ((this._TenDoUong != value))
				{
					this.OnTenDoUongChanging(value);
					this.SendPropertyChanging();
					this._TenDoUong = value;
					this.SendPropertyChanged("TenDoUong");
					this.OnTenDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loai", DbType="NVarChar(50)")]
		public string Loai
		{
			get
			{
				return this._Loai;
			}
			set
			{
				if ((this._Loai != value))
				{
					this.OnLoaiChanging(value);
					this.SendPropertyChanging();
					this._Loai = value;
					this.SendPropertyChanged("Loai");
					this.OnLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_CongThuc", Storage="_CongThucs", ThisKey="DoUongID", OtherKey="DoUongID")]
		public EntitySet<CongThuc> CongThucs
		{
			get
			{
				return this._CongThucs;
			}
			set
			{
				this._CongThucs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_SLDoUong", Storage="_SLDoUongs", ThisKey="DoUongID", OtherKey="DoUongID")]
		public EntitySet<SLDoUong> SLDoUongs
		{
			get
			{
				return this._SLDoUongs;
			}
			set
			{
				this._SLDoUongs.Assign(value);
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
		
		private void attach_CongThucs(CongThuc entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = this;
		}
		
		private void detach_CongThucs(CongThuc entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = null;
		}
		
		private void attach_SLDoUongs(SLDoUong entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = this;
		}
		
		private void detach_SLDoUongs(SLDoUong entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguyenLieu")]
	public partial class NguyenLieu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NguyenLieuID;
		
		private string _TenNguyenLieu;
		
		private System.Nullable<int> _GiaNguyenLieu;
		
		private System.Nullable<int> _SLNguyenLieu;
		
		private EntitySet<CongThuc> _CongThucs;
		
		private EntitySet<Nhap> _Nhaps;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNguyenLieuIDChanging(int value);
    partial void OnNguyenLieuIDChanged();
    partial void OnTenNguyenLieuChanging(string value);
    partial void OnTenNguyenLieuChanged();
    partial void OnGiaNguyenLieuChanging(System.Nullable<int> value);
    partial void OnGiaNguyenLieuChanged();
    partial void OnSLNguyenLieuChanging(System.Nullable<int> value);
    partial void OnSLNguyenLieuChanged();
    #endregion
		
		public NguyenLieu()
		{
			this._CongThucs = new EntitySet<CongThuc>(new Action<CongThuc>(this.attach_CongThucs), new Action<CongThuc>(this.detach_CongThucs));
			this._Nhaps = new EntitySet<Nhap>(new Action<Nhap>(this.attach_Nhaps), new Action<Nhap>(this.detach_Nhaps));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguyenLieuID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NguyenLieuID
		{
			get
			{
				return this._NguyenLieuID;
			}
			set
			{
				if ((this._NguyenLieuID != value))
				{
					this.OnNguyenLieuIDChanging(value);
					this.SendPropertyChanging();
					this._NguyenLieuID = value;
					this.SendPropertyChanged("NguyenLieuID");
					this.OnNguyenLieuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNguyenLieu", DbType="NVarChar(50)")]
		public string TenNguyenLieu
		{
			get
			{
				return this._TenNguyenLieu;
			}
			set
			{
				if ((this._TenNguyenLieu != value))
				{
					this.OnTenNguyenLieuChanging(value);
					this.SendPropertyChanging();
					this._TenNguyenLieu = value;
					this.SendPropertyChanged("TenNguyenLieu");
					this.OnTenNguyenLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaNguyenLieu", DbType="Int")]
		public System.Nullable<int> GiaNguyenLieu
		{
			get
			{
				return this._GiaNguyenLieu;
			}
			set
			{
				if ((this._GiaNguyenLieu != value))
				{
					this.OnGiaNguyenLieuChanging(value);
					this.SendPropertyChanging();
					this._GiaNguyenLieu = value;
					this.SendPropertyChanged("GiaNguyenLieu");
					this.OnGiaNguyenLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLNguyenLieu", DbType="Int")]
		public System.Nullable<int> SLNguyenLieu
		{
			get
			{
				return this._SLNguyenLieu;
			}
			set
			{
				if ((this._SLNguyenLieu != value))
				{
					this.OnSLNguyenLieuChanging(value);
					this.SendPropertyChanging();
					this._SLNguyenLieu = value;
					this.SendPropertyChanged("SLNguyenLieu");
					this.OnSLNguyenLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguyenLieu_CongThuc", Storage="_CongThucs", ThisKey="NguyenLieuID", OtherKey="NguyenLieuID")]
		public EntitySet<CongThuc> CongThucs
		{
			get
			{
				return this._CongThucs;
			}
			set
			{
				this._CongThucs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguyenLieu_Nhap", Storage="_Nhaps", ThisKey="NguyenLieuID", OtherKey="NguyenLieuID")]
		public EntitySet<Nhap> Nhaps
		{
			get
			{
				return this._Nhaps;
			}
			set
			{
				this._Nhaps.Assign(value);
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
		
		private void attach_CongThucs(CongThuc entity)
		{
			this.SendPropertyChanging();
			entity.NguyenLieu = this;
		}
		
		private void detach_CongThucs(CongThuc entity)
		{
			this.SendPropertyChanging();
			entity.NguyenLieu = null;
		}
		
		private void attach_Nhaps(Nhap entity)
		{
			this.SendPropertyChanging();
			entity.NguyenLieu = this;
		}
		
		private void detach_Nhaps(Nhap entity)
		{
			this.SendPropertyChanging();
			entity.NguyenLieu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nhap")]
	public partial class Nhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NhapID;
		
		private System.Nullable<int> _NguyenLieuID;
		
		private System.Nullable<int> _SLNhap;
		
		private System.Nullable<decimal> _tongChi;
		
		private EntityRef<NguyenLieu> _NguyenLieu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNhapIDChanging(int value);
    partial void OnNhapIDChanged();
    partial void OnNguyenLieuIDChanging(System.Nullable<int> value);
    partial void OnNguyenLieuIDChanged();
    partial void OnSLNhapChanging(System.Nullable<int> value);
    partial void OnSLNhapChanged();
    partial void OntongChiChanging(System.Nullable<decimal> value);
    partial void OntongChiChanged();
    #endregion
		
		public Nhap()
		{
			this._NguyenLieu = default(EntityRef<NguyenLieu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhapID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NhapID
		{
			get
			{
				return this._NhapID;
			}
			set
			{
				if ((this._NhapID != value))
				{
					this.OnNhapIDChanging(value);
					this.SendPropertyChanging();
					this._NhapID = value;
					this.SendPropertyChanged("NhapID");
					this.OnNhapIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguyenLieuID", DbType="Int")]
		public System.Nullable<int> NguyenLieuID
		{
			get
			{
				return this._NguyenLieuID;
			}
			set
			{
				if ((this._NguyenLieuID != value))
				{
					if (this._NguyenLieu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNguyenLieuIDChanging(value);
					this.SendPropertyChanging();
					this._NguyenLieuID = value;
					this.SendPropertyChanged("NguyenLieuID");
					this.OnNguyenLieuIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLNhap", DbType="Int")]
		public System.Nullable<int> SLNhap
		{
			get
			{
				return this._SLNhap;
			}
			set
			{
				if ((this._SLNhap != value))
				{
					this.OnSLNhapChanging(value);
					this.SendPropertyChanging();
					this._SLNhap = value;
					this.SendPropertyChanged("SLNhap");
					this.OnSLNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tongChi", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> tongChi
		{
			get
			{
				return this._tongChi;
			}
			set
			{
				if ((this._tongChi != value))
				{
					this.OntongChiChanging(value);
					this.SendPropertyChanging();
					this._tongChi = value;
					this.SendPropertyChanged("tongChi");
					this.OntongChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguyenLieu_Nhap", Storage="_NguyenLieu", ThisKey="NguyenLieuID", OtherKey="NguyenLieuID", IsForeignKey=true)]
		public NguyenLieu NguyenLieu
		{
			get
			{
				return this._NguyenLieu.Entity;
			}
			set
			{
				NguyenLieu previousValue = this._NguyenLieu.Entity;
				if (((previousValue != value) 
							|| (this._NguyenLieu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NguyenLieu.Entity = null;
						previousValue.Nhaps.Remove(this);
					}
					this._NguyenLieu.Entity = value;
					if ((value != null))
					{
						value.Nhaps.Add(this);
						this._NguyenLieuID = value.NguyenLieuID;
					}
					else
					{
						this._NguyenLieuID = default(Nullable<int>);
					}
					this.SendPropertyChanged("NguyenLieu");
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
