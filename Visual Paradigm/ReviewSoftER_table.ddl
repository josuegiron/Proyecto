DROP TABLE Software;
DROP TABLE Comparacion;
DROP TABLE Categoria;
DROP TABLE Categoria_Software;
DROP TABLE Propietario;
DROP TABLE Plataforma;
DROP TABLE Plataforma_soportada;
DROP TABLE [Plan];
DROP TABLE Precio;
DROP TABLE Retroalimentacion;
DROP TABLE Metrica;
DROP TABLE Puntaje;
DROP TABLE Software_participante;
DROP TABLE Recomendacion;
DROP TABLE Usuario;
DROP TABLE Rol;
CREATE TABLE Software (
  num_software    int IDENTITY NOT NULL, 
  nom_software    char(100) NOT NULL, 
  descripcion     varchar(300) NOT NULL, 
  url             varchar(300) NOT NULL, 
  licencia        char(50) NOT NULL, 
  demo            char(50) NOT NULL, 
  soporte         char(50) NOT NULL, 
  num_usuarios    int NOT NULL, 
  fecha_creacion  date NOT NULL, 
  num_propietario int NOT NULL);
CREATE TABLE Comparacion (
  num_comparacion int IDENTITY NOT NULL, 
  fecha           date NOT NULL, 
  usuario         char(100) NOT NULL, 
  num_usuario     int NOT NULL);
CREATE TABLE Categoria (
  num_categoria int IDENTITY NOT NULL, 
  nom_categoria char(100) NOT NULL, 
  descripcion   char(300) NOT NULL);
CREATE TABLE Categoria_Software (
  num_software  int NOT NULL, 
  num_categoria int NOT NULL, 
  Orden         int NOT NULL UNIQUE);
CREATE TABLE Propietario (
  num_propietario int IDENTITY NOT NULL, 
  nom_propietario char(100) NOT NULL, 
  sitio_web       varchar(100) NOT NULL, 
  valor           varchar(100) NOT NULL, 
  fecha_fundacion date NOT NULL, 
  correo          varchar(100) NOT NULL, 
  facebook        varchar(100) NULL, 
  twitter         varchar(100) NULL);
CREATE TABLE Plataforma (
  num_plataforma int IDENTITY NOT NULL, 
  nom_plataforma char(100) NOT NULL, 
  tipo           char(50) NOT NULL, 
  descripcion    char(300) NOT NULL);
CREATE TABLE Plataforma_soportada (
  num_plataforma   int NOT NULL, 
  num_software     int NOT NULL, 
  espesificaciones char(300) NOT NULL);
CREATE TABLE [Plan] (
  num_plan    int IDENTITY NOT NULL, 
  nom_plan    int NOT NULL, 
  descripcion varchar(300) NOT NULL);
CREATE TABLE Precio (
  num_plan         int NOT NULL, 
  num_software     int NOT NULL, 
  precio           float(10) NOT NULL, 
  espesificaciones char(300) NOT NULL);
CREATE TABLE Retroalimentacion (
  num_software    int NOT NULL, 
  num_usuario     int NOT NULL, 
  experiencia_uso char(300) NOT NULL, 
  ventajas        char(200) NOT NULL, 
  desventajas     char(200) NOT NULL, 
  tiempo_uso      time NOT NULL, 
  frecuencia_uso  char(50) NOT NULL, 
  rol             char(50) NOT NULL);
CREATE TABLE Metrica (
  num_metrica int IDENTITY NOT NULL, 
  nom_metrica char(100) NOT NULL, 
  descripcion char(300) NOT NULL);
CREATE TABLE Puntaje (
  num_metrica  int NOT NULL, 
  num_software int NOT NULL, 
  num_usuario  int NOT NULL, 
  puntaje      int NOT NULL);
CREATE TABLE Software_participante (
  num_comparacion int NOT NULL, 
  num_software    int NOT NULL, 
  ganadora        char(10) DEFAULT '0' NOT NULL);
CREATE TABLE Recomendacion (
  num_recomendacion int IDENTITY NOT NULL, 
  fecha             date NOT NULL, 
  num_comparacion   int NOT NULL);
CREATE TABLE Usuario (
  num_usuario int IDENTITY NOT NULL, 
  usuario     char(100) NOT NULL UNIQUE, 
  password    varchar(1000) NOT NULL, 
  nombre      char(100) NOT NULL, 
  apellido    char(100) NOT NULL, 
  fecha_nac   date NOT NULL, 
  correo      varchar(100) NOT NULL, 
  profesion   char(100) NOT NULL, 
  id_rol      int NOT NULL);
CREATE TABLE Rol (
  id_rol  int IDENTITY NOT NULL, 
  nom_rol char(100) NULL UNIQUE);
