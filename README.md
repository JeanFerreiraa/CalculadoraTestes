# \# Calculadora - .NET 10 \& Stryker.NET

# 

# Este projeto é uma biblioteca de serviços de cálculo matemático desenvolvida em \*\*C# (.NET 10)\*\*, acompanhada por uma suíte de \*\*testes unitários\*\* (com \*\*xUnit\*\*) e suporte a \*\*testes de mutação\*\* utilizando o \*\*Stryker.NET\*\*.

# 

# \---

# 

# \## 🛠️ Tecnologias Utilizadas

# 

# \* \*\*.NET 10.0 SDK\*\* (C#)

# \* \*\*xUnit\*\* (Framework de testes unitários)

# \* \*\*Coverlet Collector\*\* (Análise de cobertura de código)

# \* \*\*Stryker.NET (v5.0.0)\*\* (Ferramenta de testes de mutação)

# 

# \---

# 

# \## 📁 Estrutura do Projeto

# 

# \* `Calculadora/`: Biblioteca principal contendo a regra de negócio (`CalculadoraService.cs`).

# \* `CalculadoraTest/`: Projeto contendo a suíte de testes automatizados (`UnitTest1.cs`).

# \* `Calculadora.slnx`: Ficheiro de solução do projeto.

# \* `dotnet-tools.json`: Configuração de ferramentas locais .NET (Stryker.NET).

# 

# \---

# 

# \## ⚙️ Funcionalidades (`CalculadoraService`)

# 

# A classe `CalculadoraService` disponibiliza os seguintes métodos de cálculo:

# 

# \* `Somar(decimal valor1, decimal valor2)`: Realiza a adição entre dois valores.

# \* `Subtrair(decimal valor1, decimal valor2)`: Realiza a subtração entre dois valores.

# \* `Multiplicar(decimal valor1, decimal valor2)`: Realiza a multiplicação de dois valores.

# \* `Dividir(decimal valor1, decimal valor2)`: Realiza a divisão entre dois valores.

# \* `EhPar(decimal valor)`: Verifica se determinado valor é par (retorna `true` ou `false`).

# 

# \---

# 

# \## 🚀 Como Executar o Projeto

# 

# \### Pré-requisitos

# \* \[.NET 10.0 SDK](https://dotnet.microsoft.com/) instalado na máquina.

# 

# \### 1. Compilar o Projeto

# Para compilar a solução e restaurar as dependências:

# ```bash

# dotnet build





# \### 2. Executar os Testes Unitários

# Para rodar todos os testes automatizados com o xUnit:

# ```bash

# dotnet test





# \### Executar os Testes de Mutação (Stryker)

# O Stryker.NET avalia a qualidade e cobertura real dos seus testes através da criação de mutantes no código-fonte.

# Restaure as ferramentas locais definidas no projeto:

# ```bash

# dotnet tool restore

# 

# Navegue até à pasta do projeto de testes e execute o Stryker:

# 

# cd CalculadoraTest

# dotnet stryker











