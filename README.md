# Gerador de Pirâmide de Pascal

Este projeto é um programa simples de console que gera uma Pirâmide de Pascal (ou Triângulo de Pascal) com base no número de linhas especificado pelo usuário. Ele implementa conceitos de fatoriais e combinações para construir cada linha da pirâmide. O programa também possui uma interface de console com opções para continuar ou sair.

## Estrutura do Projeto

- **Namespace `Algs`**: Contém os métodos principais para o funcionamento do programa.
- **Classe `ProgramDesign`**: Responsável por exibir o cabeçalho e as opções do menu.
- **Classe `Methods`**: Contém os métodos que calculam fatoriais, combinações e geram a pirâmide.

## Funcionalidades

1. **Gerar Pirâmide de Pascal**: O usuário pode inserir o número de linhas desejado e o programa gera a pirâmide correspondente.
2. **Opção de Sair**: A qualquer momento o usuário pode escolher sair do programa.

## Classes e Métodos Principais

### ProgramDesign

- `Header()`: Exibe um cabeçalho simples no console.
- `Options()`: Exibe as opções disponíveis para o usuário.

### Methods

- `Factorial(int num)`: Calcula o fatorial de um número.
- `Combination(int elements, int positions)`: Calcula a combinação de elementos e posições com a fórmula \( C(a, b) = a! / (b!(a - b)!) \).
- `Ppyramid(int rows)`: Gera e exibe a Pirâmide de Pascal com o número de linhas especificado.

## Exemplo de Uso

1. Execute o programa.
2. Insira "1" para gerar uma pirâmide.
3. Digite o número de linhas da pirâmide.
4. O programa exibirá a pirâmide e perguntará se deseja continuar ou sair.

## Exemplo de Saída

Se o usuário escolher gerar uma pirâmide com 5 linhas, a saída será semelhante a:

- 1
- 1 1
- 1 2 1
- 1 3 3 1
- 1 4 6 4 1


O programa então perguntará ao usuário se deseja continuar (`s`) ou sair (`n`).

## Requisitos

- .NET SDK instalado para compilar e executar o projeto.

## Como Executar

1. Clone este repositório.
2. Compile o código com o comando `dotnet build`.
3. Execute o código com o comando `dotnet run`.

## Licença

Este projeto é distribuído sob a licença MIT. Sinta-se à vontade para usá-lo e modificá-lo.

---

Desenvolvido para aprendizado em C#.
