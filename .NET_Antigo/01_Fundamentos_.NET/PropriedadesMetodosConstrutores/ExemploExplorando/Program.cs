﻿// See https://aka.ms/new-console-template for more information
using ExemploExplorando.models;

// Pessoa p1 = new Pessoa(); // instanciando a classe pessoa a p1

// p1.Idade = 36;
// p1.Nome = "Dener";
// p1.Sobrenome = "Silva";
// p1.Apresentar();

Pessoa p1 = new Pessoa("Denerval", "Pelizario"); // instanciando a classe pessoa a p1

Pessoa p2 = new Pessoa(nome: "Tom", sobrenome: "Pelizario"); // instanciando a classe pessoa a p2, esse nome:, sobrenome: é opcional são o parametro dos construtores

Curso cursoDeIngles = new Curso(); // criando uma variavel(cursoDeIngles) que recebe a classe Curso
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>(); // instanciando em alunos a classe list Pessoa

cursoDeIngles.AdicionarAluno(p1); // adicionano a list curso de ingles p1
cursoDeIngles.AdicionarAluno(p2); // adicionano a list curso de ingles p2
cursoDeIngles.ListarAlunos();


