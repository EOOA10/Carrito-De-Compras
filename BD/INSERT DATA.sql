SELECT * FROM USUARIO
INSERT INTO USUARIO(Nombre, Apellido, Correo, Clave) VALUES ('Admin', 'Admin', 'edisonomarordonez@gmail.com', 'e7845bfeb552c3344cdf8b55cdf45bed8b5afaf91d561ca5cafc6ecce8f57a76')

SELECT * FROM CATEGORIA
INSERT INTO CATEGORIA(Descripcion) VALUES
('Tecnologia'),
('Muebles'),
('Dormitorio'),
('Deportes')

SELECT * FROM MARCA
INSERT INTO MARCA(Descripcion) VALUES
('SONY'),
('HP'),
('LG'),
('HYUNDAI'),
('CANON'),
('NIKE')

SELECT * FROM DEPARTAMENTO
INSERT INTO DEPARTAMENTO(IdDepartamento, Descripcion) VALUES
('08','Francisco Morazan'),
('03','Comayagua'),
('12','La Paz')

SELECT * FROM PROVINCIA
INSERT INTO PROVINCIA(IdProvincia, Descripcion, IdDepartamento) VALUES
('0801','Distrito Central', '08'),
('0306','La Libertad', '03'),
('1203','Cabañas', '12')

SELECT * FROM DISTRITO
INSERT INTO DISTRITO(IdDistrito, Descripcion, IdProvincia, IdDepartamento) VALUES
('080101','Tegucigalpa','0801','08'),
('030602','Libertad','0306','03'),
('120305','Cabañas','1203','12')
