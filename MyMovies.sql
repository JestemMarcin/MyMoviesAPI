create database MyMovies
go
use MyMovies
go
Create Table Movie(
id int Identity(1,1) Primary Key,
name Varchar(200) Not Null,
production_year int
)
go
insert Into Movie(name, production_year) Values ('movie1',1990);
insert Into Movie(name, production_year) Values ('movie2',2010);
insert Into Movie(name, production_year) Values ('movie1',null);
go