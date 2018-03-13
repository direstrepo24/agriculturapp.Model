using Microsoft.EntityFrameworkCore;
using System.Linq;
using datamakerslib.DataContext;
using agricultureapp.Model.Models.AsisTecnica;
using agricultureapp.Model.Models.Comercial;
using agricultureapp.Model.Models.Contabilidad;

namespace agricultureapp.Model.DataContext
{
    public class MyAppContext: EntityContextBase<MyAppContext>
    {
       
        #region Atributes
        static DbContextOptions<MyAppContext> optionsLocal;
        static MyAppContext instance;

        #endregion

        #region Singleton
        public static MyAppContext GetInstance()
        {
            if (instance == null)
            {
                instance = new MyAppContext();
            }

            return instance;
        }
        #endregion


        #region constructor
       // public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
       //{}
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
            optionsLocal=options;
        }

        public MyAppContext() : base(optionsLocal)
        {


        }

        #endregion
        ///Modulo de Asistencia técnica
         public DbSet<Categoria_Insumo> Categoria_Insumo { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Departamento> Departamento{get;set;}
        public DbSet<ControlPlaga> ControlPlaga { get; set; }
        public DbSet<Cultivo> Cultivo { get; set; }
        public DbSet<DetalleCategoria_Insumo> DetalleCategoria_Insumo { get; set; }
        public DbSet<Enfermedades> Enfermedades { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<Insumo> Insumo { get; set; }
        public DbSet<Laboratorio> Laboratorio { get; set; }
        public DbSet<LocalizacionUp> LocalizacionUp { get; set; }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<Receta> Receta { get; set; }
       
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Tipo_Insumo> Tipo_Insumo { get; set; }
        public DbSet<Tratamiento> Tratamiento { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<UnidadProductiva> UnidadProductiva { get; set; }
         public DbSet<Produccion> Produccion { get; set; }      
        public DbSet<Usuario> Usuario { get; set; }
        ///Modulo comercial
        public DbSet<Calidad> Calidad { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<ComprasPagos> ComprasPagos { get; set; }
        public DbSet<Ofertas> Ofertas { get; set; }
        public DbSet<DetalleCompra> DetalleCompra { get; set; }
        public DbSet<DetalleOferta> DetalleOferta { get; set; }
        public DbSet<DetalleMetodopago> DetalleMetodopago { get; set; }
         public DbSet<DetalleTipoProducto> DetalleTipoProducto { get; set; }
        
        public DbSet<MetodoPago> MetodoPago { get; set; }
         public DbSet<Notificaciones> Notificaciones { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<ProductCategoria> ProductCategoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<TypeNotification> TypeNotification { get; set; }
        ///Módulo contable
        public DbSet<CategoriaPUC> CategoriaPUC { get; set; }  
        public DbSet<Estado> Estado { get; set; }   
        public DbSet<Naturaleza> Naturaleza { get; set; }  
        public DbSet<PUC> PUC { get; set; } 
        public DbSet<Tercero> Tercero { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               /* 
            modelBuilder.Entity<Elemento>()
             .HasMany(e => e.Novedades)
            .WithOne(c => c.Elemento).HasForeignKey(c=>c.Elemento_Id);
           */
           //modulo Técnico

           modelBuilder.Entity<LocalizacionUp>()
            .HasIndex(u => u.UnidadProductivaId)
            .IsUnique();//no permitir geolocalizar una unidad productiva con el mismo codigo

            modelBuilder.Entity<Categoria_Insumo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Ciudad>().HasKey(m=>m.Id);
            modelBuilder.Entity<ControlPlaga>().HasKey(m=>m.Id);
            modelBuilder.Entity<Cultivo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Departamento>().HasKey(m=>m.Id);
            modelBuilder.Entity<Enfermedades>().HasKey(m=>m.Id);
            modelBuilder.Entity<DetalleCategoria_Insumo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Equipo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Foto>().HasKey(m=>m.Id);
            modelBuilder.Entity<Insumo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Laboratorio>().HasKey(m=>m.Id);
            modelBuilder.Entity<LocalizacionUp>().HasKey(m=>m.Id);
            modelBuilder.Entity<Lote>().HasKey(m=>m.Id);
            modelBuilder.Entity<Produccion>().HasKey(m=>m.Id);
            modelBuilder.Entity<Receta>().HasKey(m=>m.Id);
            
            modelBuilder.Entity<Rol>().HasKey(m=>m.Id);
            modelBuilder.Entity<Tipo_Insumo>().HasKey(m=>m.Id);
            modelBuilder.Entity<Tratamiento>().HasKey(m=>m.Id);
            modelBuilder.Entity<UnidadMedida>().HasKey(m=>m.Id);
            modelBuilder.Entity<UnidadProductiva>().HasKey(m=>m.Id);
            modelBuilder.Entity<Usuario>().HasKey(m=>m.Id);

            //módulo Comercial
            modelBuilder.Entity<Calidad>().HasKey(m=>m.Id);
            modelBuilder.Entity<Categoria>().HasKey(m=>m.Id);
            
            modelBuilder.Entity<Compras>().HasKey(m=>m.Id);
            modelBuilder.Entity<ComprasPagos>().HasKey(m=>m.Id);
            modelBuilder.Entity<DetalleCompra>().HasKey(m=>m.Id);
            modelBuilder.Entity<Ofertas>().HasKey(m=>m.Id);
            modelBuilder.Entity<DetalleOferta>().HasKey(m=>m.Id);
            modelBuilder.Entity<DetalleMetodopago>().HasKey(m=>m.Id);
            modelBuilder.Entity<DetalleTipoProducto>().HasKey(m=>m.Id);
         
            modelBuilder.Entity<MetodoPago>().HasKey(m=>m.Id);
            modelBuilder.Entity<Notificaciones>().HasKey(m=>m.Id);
            modelBuilder.Entity<Pagos>().HasKey(m=>m.Id);
            modelBuilder.Entity<ProductCategoria>().HasKey(m=>m.Id);
            modelBuilder.Entity<Producto>().HasKey(m=>m.Id);
            modelBuilder.Entity<TypeNotification>().HasKey(m=>m.Id);
            base.OnModelCreating(modelBuilder); 
            
 
        }
        
    }
}