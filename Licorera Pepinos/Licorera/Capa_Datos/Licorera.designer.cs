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

namespace Capa_Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Licorera_Pepinos")]
	public partial class LicoreraDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public LicoreraDataContext() : 
				base(global::Capa_Datos.Properties.Settings.Default.Licorera_PepinosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LicoreraDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicoreraDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicoreraDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LicoreraDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ActualizarUsuario")]
		public int ActualizarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cedula", DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido1", DbType="VarChar(50)")] string apellido1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido2", DbType="VarChar(50)")] string apellido2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FecNacimiento", DbType="DateTime")] System.Nullable<System.DateTime> fecNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="VarChar(50)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdRol", DbType="Int")] System.Nullable<int> idRol)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, cedula, nombre, apellido1, apellido2, telefono, fecNacimiento, email, pass, idRol);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarUsuario")]
		public int AgregarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cedula", DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido1", DbType="VarChar(50)")] string apellido1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido2", DbType="VarChar(50)")] string apellido2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FecNacimiento", DbType="DateTime")] System.Nullable<System.DateTime> fecNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="VarChar(50)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdRol", DbType="Int")] System.Nullable<int> idRol)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cedula, nombre, apellido1, apellido2, telefono, fecNacimiento, email, pass, idRol);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarUsuarioCliente")]
		public int AgregarUsuarioCliente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cedula", DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido1", DbType="VarChar(50)")] string apellido1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido2", DbType="VarChar(50)")] string apellido2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FecNacimiento", DbType="DateTime")] System.Nullable<System.DateTime> fecNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="VarChar(50)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cedula, nombre, apellido1, apellido2, telefono, fecNacimiento, email, pass);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarUsuario")]
		public int EliminarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.IniciarSesion")]
		public ISingleResult<IniciarSesionResult> IniciarSesion([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Correo", DbType="VarChar(100)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Clave", DbType="VarChar(50)")] string clave)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), correo, clave);
			return ((ISingleResult<IniciarSesionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VerUsuario")]
		public ISingleResult<VerUsuarioResult> VerUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((ISingleResult<VerUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VerUsuarios")]
		public ISingleResult<VerUsuariosResult> VerUsuarios()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<VerUsuariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.VerRoles")]
		public ISingleResult<VerRolesResult> VerRoles()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<VerRolesResult>)(result.ReturnValue));
		}
	}
	
	public partial class IniciarSesionResult
	{
		
		private int _ID;
		
		private int _Cedula;
		
		private string _Nombre;
		
		private string _Apellido1;
		
		private string _Apellido2;
		
		private int _Telefono;
		
		private System.DateTime _FecNacimiento;
		
		private string _Email;
		
		private string _Pass;
		
		private int _IdRol;
		
		public IniciarSesionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL")]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this._Cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido1
		{
			get
			{
				return this._Apellido1;
			}
			set
			{
				if ((this._Apellido1 != value))
				{
					this._Apellido1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido2", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido2
		{
			get
			{
				return this._Apellido2;
			}
			set
			{
				if ((this._Apellido2 != value))
				{
					this._Apellido2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int NOT NULL")]
		public int Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FecNacimiento", DbType="DateTime NOT NULL")]
		public System.DateTime FecNacimiento
		{
			get
			{
				return this._FecNacimiento;
			}
			set
			{
				if ((this._FecNacimiento != value))
				{
					this._FecNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this._Pass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRol", DbType="Int NOT NULL")]
		public int IdRol
		{
			get
			{
				return this._IdRol;
			}
			set
			{
				if ((this._IdRol != value))
				{
					this._IdRol = value;
				}
			}
		}
	}
	
	public partial class VerUsuarioResult
	{
		
		private int _ID;
		
		private int _Cedula;
		
		private string _Nombre;
		
		private string _Apellido1;
		
		private string _Apellido2;
		
		private int _Telefono;
		
		private System.DateTime _FecNacimiento;
		
		private string _Email;
		
		private string _Pass;
		
		private int _IdRol;
		
		public VerUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL")]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this._Cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido1
		{
			get
			{
				return this._Apellido1;
			}
			set
			{
				if ((this._Apellido1 != value))
				{
					this._Apellido1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido2", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido2
		{
			get
			{
				return this._Apellido2;
			}
			set
			{
				if ((this._Apellido2 != value))
				{
					this._Apellido2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int NOT NULL")]
		public int Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FecNacimiento", DbType="DateTime NOT NULL")]
		public System.DateTime FecNacimiento
		{
			get
			{
				return this._FecNacimiento;
			}
			set
			{
				if ((this._FecNacimiento != value))
				{
					this._FecNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this._Pass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRol", DbType="Int NOT NULL")]
		public int IdRol
		{
			get
			{
				return this._IdRol;
			}
			set
			{
				if ((this._IdRol != value))
				{
					this._IdRol = value;
				}
			}
		}
	}
	
	public partial class VerUsuariosResult
	{
		
		private int _ID;
		
		private int _Cedula;
		
		private string _Nombre;
		
		private string _Apellido1;
		
		private string _Apellido2;
		
		private int _Telefono;
		
		private System.DateTime _FecNacimiento;
		
		private string _Email;
		
		private string _Pass;
		
		private int _IdRol;
		
		public VerUsuariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL")]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this._Cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido1
		{
			get
			{
				return this._Apellido1;
			}
			set
			{
				if ((this._Apellido1 != value))
				{
					this._Apellido1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido2", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido2
		{
			get
			{
				return this._Apellido2;
			}
			set
			{
				if ((this._Apellido2 != value))
				{
					this._Apellido2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int NOT NULL")]
		public int Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FecNacimiento", DbType="DateTime NOT NULL")]
		public System.DateTime FecNacimiento
		{
			get
			{
				return this._FecNacimiento;
			}
			set
			{
				if ((this._FecNacimiento != value))
				{
					this._FecNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this._Pass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRol", DbType="Int NOT NULL")]
		public int IdRol
		{
			get
			{
				return this._IdRol;
			}
			set
			{
				if ((this._IdRol != value))
				{
					this._IdRol = value;
				}
			}
		}
	}
	
	public partial class VerRolesResult
	{
		
		private int _ID;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		public VerRolesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
