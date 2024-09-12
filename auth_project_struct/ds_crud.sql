create database ds_crud;

use ds_crud;

create table users(
	id int primary key auto_increment,
	username varchar(40),
	pass varchar(40)
);