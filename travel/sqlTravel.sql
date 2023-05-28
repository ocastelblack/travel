-- Crear tabla Autores
CREATE TABLE Autores (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(45),
  apellidos VARCHAR(45)
);

-- Crear tabla editoriales
CREATE TABLE editoriales (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(45),
  sede VARCHAR(45)
);

-- Crear tabla Libros
CREATE TABLE Libros (
  ISBN INT IDENTITY(1,1) PRIMARY KEY,
  editoriales_id INT,
  titulo VARCHAR(45),
  sinopsis TEXT,
  n_paginas VARCHAR(45),
  FOREIGN KEY (editoriales_id) REFERENCES editoriales(id)
);
-- Crear tabla autores_has_libros
CREATE TABLE autores_has_libros (
  autores_id INT,
  libros_ISBN INT,
  FOREIGN KEY (autores_id) REFERENCES Autores(Id),
  FOREIGN KEY (libros_ISBN) REFERENCES Libros(ISBN)
);

-- Ingresar datos en la tabla Autores
INSERT INTO autores (nombre, apellidos)
VALUES
  ('George', 'Orwell'),
  ('Harper', 'Lee'),
  ('F. Scott', 'Fitzgerald');

-- Ingresar datos en la tabla Editoriales
INSERT INTO editoriales (nombre, sede)
VALUES
  ('Penguin Random House', 'Nueva York'),
  ('HarperCollins Publishers', 'Londres'),
  ('Simon & Schuster', 'Nueva York');

-- Ingresar datos en la tabla Libros
INSERT INTO libros (editoriales_id, titulo, sinopsis, n_paginas)
VALUES
  (1, '1984', '1984 es una novela de ficción distópica...', '328'),
  (2, 'To Kill a Mockingbird', 'To Kill a Mockingbird is a novel by Harper Lee...', '336'),
  (3, 'The Great Gatsby', 'The Great Gatsby is a novel by F. Scott Fitzgerald...', '180');



