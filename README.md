# Calculadora - .NET 10 & Stryker.NET

Biblioteca de serviços de cálculo matemático desenvolvida em **C# (.NET 10)**, acompanhada por uma suíte de **testes unitários** (com **xUnit**) e suporte a **testes de mutação** utilizando o **Stryker.NET**.

## 🛠️ Tecnologias Utilizadas

* **.NET 10.0 SDK** (C#)
* **xUnit** (Framework de testes unitários)
* **Coverlet Collector** (Análise de cobertura de código)
* **Stryker.NET** (Ferramenta de testes de mutação)

## 📁 Estrutura do Projeto

* `Calculadora/`: Biblioteca principal contendo a regra de negócio (`CalculadoraService.cs`).
* `CalculadoraTest/`: Projeto contendo a suíte de testes automatizados (`UnitTest1.cs`).
* `Calculadora.slnx`: Ficheiro de solução do projeto.
* `dotnet-tools.json`: Configuração de ferramentas locais .NET (Stryker.NET).

## ⚙️ Funcionalidades (`CalculadoraService`)

A classe `CalculadoraService` disponibiliza os seguintes métodos de cálculo:

* `Somar(decimal valor1, decimal valor2)`: Realiza a adição entre dois valores.
* `Subtrair(decimal valor1, decimal valor2)`: Realiza a subtração entre dois valores.
* `Multiplicar(decimal valor1, decimal valor2)`: Realiza a multiplicação de dois valores.
* `Dividir(decimal valor1, decimal valor2)`: Realiza a divisão entre dois valores (com tratamento para divisão por zero).
* `EhPar(decimal valor)`: Verifica se determinado valor é par (retorna `true` ou `false`).

## 🚀 Passo a Passo de Compilação e Testes

### 1. Pré-requisitos
* [.NET 10.0 SDK](https://dotnet.microsoft.com/) instalado no sistema.

---

### 2. Compilar a Solução
Para restaurar dependências e compilar a solução completa:
```bash
dotnet build