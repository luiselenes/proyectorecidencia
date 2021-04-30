CREATE DATABASE almacen;
USE almacen;

CREATE TABLE Partidas(
    id_partida bigint,
    descripcion VARCHAR(500)
);

CREATE TABLE Insumos(
    id_insumo BIGINT ,
    descripcion VARCHAR(500),
    id_tipo_insumo BIGINT,
    costo_unitario FLOAT,
    unidad_medidaint VARCHAR (10)
);

CREATE TABLE Requisicion_Compras(
    id_compra BIGINT,
    id_insumo BIGINT,
    fecha DATETIME,
    cantidad FLOAT,
    comprador VARCHAR(100),
    numero INT,
    solicitante
    revisor
    autorizante
    observaciones
    centro_costo
    prioridad
    unidad
);
CREATE TABLE Proveedores(
    id_provedor
    nombre
    rfc
    direccion
);
CREATE TABLE Almacenes(
    id_almacen
    decripcion
    direccion
);
CREATE TABLE Entradas(
    id_entrada
    id_almacen
    id_insumo
    id_proveedor
    fecha_entrada
    cantidad
    importe
    id_compra
);
CREATE TABLE Inventario(
    id_insumo
    id_entrada
    cantidad
);
CREATE TABLE Requisiciones_Insumo(
    id_requisicion
    numero
    fecha
    solicitante
    revisor
    autorizante
    id_insumo
    cantidad
    observaciones
    centro_costo
    prioridad
    unidad
);
CREATE TABLE Estructuras(
   descripcion
    id_insumo
    cantidad
 
);

CREATE TABLE Modulos(
    modulo_id
    descripcion
    id_estructrua
    insumo_modulo
);
CREATE TABLE Roles(
    id_rol
    descripcion
);
CREATE TABLE Usuarios(
    id_usurio
    nombre
    apellido
    id_rol
    ultima_entrada
);