USE [nerdflix]
GO
/****** Object:  Table [dbo].[cabesera_compra]    Script Date: 28/11/16 16:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cabesera_compra](
	[cod_cabesera] [int] NOT NULL,
	[rut] [varchar](15) NOT NULL,
	[fecha] [varchar](10) NOT NULL,
	[num_tarjeta] [varchar](50) NOT NULL,
	[direccion_envio] [varchar](50) NOT NULL,
	[medio_pago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cabesera_compra] PRIMARY KEY CLUSTERED 
(
	[cod_cabesera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra](
	[cod_detalle] [int] NOT NULL,
	[cod_pelicula] [int] NOT NULL,
	[cod_cabesera] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[total] [int] NOT NULL,
 CONSTRAINT [PK_detalle_compra] PRIMARY KEY CLUSTERED 
(
	[cod_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[genero]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[genero](
	[cod_genero] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_genero] PRIMARY KEY CLUSTERED 
(
	[cod_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pelicula]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pelicula](
	[cod_plicula] [int] NOT NULL,
	[titulo] [varchar](30) NOT NULL,
	[año] [int] NOT NULL,
	[duracion] [int] NOT NULL,
	[cod_genero] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_pelicula] PRIMARY KEY CLUSTERED 
(
	[cod_plicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[persona]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[persona](
	[rut] [varchar](15) NOT NULL,
	[dv_rut] [varchar](1) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[fecha_nacimiento] [varchar](10) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ranking]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ranking](
	[cod_ranking] [int] NOT NULL,
	[cod_pelicula] [int] NOT NULL,
	[puntaje] [int] NOT NULL,
	[rut] [varchar](15) NOT NULL,
 CONSTRAINT [PK_ranking] PRIMARY KEY CLUSTERED 
(
	[cod_ranking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[cabesera_compra]  WITH CHECK ADD  CONSTRAINT [FK_cabesera_compra_persona] FOREIGN KEY([rut])
REFERENCES [dbo].[persona] ([rut])
GO
ALTER TABLE [dbo].[cabesera_compra] CHECK CONSTRAINT [FK_cabesera_compra_persona]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_cabesera_compra] FOREIGN KEY([cod_cabesera])
REFERENCES [dbo].[cabesera_compra] ([cod_cabesera])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_cabesera_compra]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_pelicula] FOREIGN KEY([cod_pelicula])
REFERENCES [dbo].[pelicula] ([cod_plicula])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_pelicula]
GO
ALTER TABLE [dbo].[pelicula]  WITH CHECK ADD  CONSTRAINT [FK_pelicula_genero1] FOREIGN KEY([cod_genero])
REFERENCES [dbo].[genero] ([cod_genero])
GO
ALTER TABLE [dbo].[pelicula] CHECK CONSTRAINT [FK_pelicula_genero1]
GO
ALTER TABLE [dbo].[ranking]  WITH CHECK ADD  CONSTRAINT [FK_ranking_pelicula] FOREIGN KEY([cod_pelicula])
REFERENCES [dbo].[pelicula] ([cod_plicula])
GO
ALTER TABLE [dbo].[ranking] CHECK CONSTRAINT [FK_ranking_pelicula]
GO
/****** Object:  StoredProcedure [dbo].[calcula_ranking]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[calcula_ranking] (@cod_pelicula varchar (15))
as
begin
select avg(puntaje) from ranking 
inner join pelicula on pelicula.cod_plicula=ranking.cod_pelicula
where cod_plicula = @cod_pelicula
end

GO
/****** Object:  StoredProcedure [dbo].[ingresa_persona]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ingresa_persona]
		@rut varchar (10),
		@dv varchar(1),
		@direccion varchar(50),
		@nombre varchar(50),
		@apellido varchar (50),
		@email varchar (50),
		@fecha_nacimiento varchar (10),
		@pass varchar (50),
		@telefono int 

as
if exists(select 2 
from persona
where rut=@rut)

begin
update persona 
set			
			--rut = @rut,
			direccion=@direccion,
			nombre = @nombre,
			apellido = @apellido,
			email = @email,
			fecha_nacimiento = @fecha_nacimiento,
			pass = @pass,
			telefono = @telefono
			
			where rut = @rut
end
else
begin
insert into persona (rut,
					 dv_rut,
					 direccion,
					 nombre,
					 apellido,
					 email,
					 fecha_nacimiento,
					 pass,
					 telefono)
values (@rut,
		@dv,
		@direccion,
		@nombre,
		@apellido,
		@email,
		@fecha_nacimiento,
		@pass,
		@telefono)
end

GO
/****** Object:  StoredProcedure [dbo].[ingresar_pelicula]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ingresar_pelicula](@cod_plicula int,
								@titulo varchar (30),
								@año int,
								@duracion int,
								@cod_genero int,
								@stock int,
								@foto varchar (50),
								@precio int )
as
if exists(select 2 
from pelicula
where cod_plicula=@cod_plicula)

begin
update pelicula
set			
			cod_plicula = @cod_plicula,
			titulo = @titulo,
			año = @año,
			duracion = @duracion,
			cod_genero = @cod_genero,
			stock = @stock,
			foto = @foto,
			precio = @precio
			
			where cod_plicula = @cod_plicula
end
else
begin
insert into pelicula (cod_plicula,
					 titulo,
					 año,
					 duracion,
					 cod_genero,
					 stock,
					 foto,
					 precio)
values				(@cod_plicula,
					 @titulo,
					 @año,
					 @duracion,
					 @cod_genero,
					 @stock,
					 @foto,
					 @precio)
end
GO
/****** Object:  StoredProcedure [dbo].[lista_pelicula]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[lista_pelicula]
as
begin
select * from pelicula
end

GO
/****** Object:  StoredProcedure [dbo].[lista_persona]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[lista_persona]
as
begin
select * from persona
end

GO
/****** Object:  StoredProcedure [dbo].[listar_combo_pelicula]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_combo_pelicula]
as
begin
select titulo from pelicula;
end
GO
/****** Object:  StoredProcedure [dbo].[listar_pelicula_grilla]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_pelicula_grilla]
as
begin
select * from pelicula;
end
GO
/****** Object:  StoredProcedure [dbo].[ObtieneGenero]    Script Date: 28/11/16 16:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtieneGenero]


AS
BEGIN
	Select '0' Codigo, '[Seleccione]' Nombre
		union all
		Select cod_genero,nombre from genero

END

GO
