# DIO - Trilha .NET - Fundamentos
[DIO](www.dio.me)

# Minhas Implementações

Dada a simplicidade do desafio, que já vem semipronto e só pede para implementar 3 funções - adicionar veículos a uma lista, ler a lista, exibir os veículos cadastrados e remover um veículo - de uma forma muito simples: no projeto inicial, o sistema vai pedir para o usuário digitar quantas horas o veículo passou estacionado. Decidi remover essa obrigação do usuário e deixar que o próprio sistema determine o tempo que o carro passou dentro do estacionamento. Isso me levou a estudar mais a linguagem e descobrir o método Subtract, a classe TimeSpan, entre outros, além do que foi ensinado nas aulas do bootcamp. Seguem as implementações e, ao final delas, o descritivo original do desafio.

### Implementações

 - Primeiramente, criei uma classe chamada Entrada, que registra a placa do veículo e a hora de sua entrada no estacionamento.
 - Alterei o tipo da lista que guarda os veículos estacionados para o tipo Entrada, que foi criado no sistema.
#### Método AdicionarVeiculo
 - No método AdicionarVeiculo, eu crio uma instância da classe Entrada.
 - Solicito a placa do veículo ao usuário (que já vem pronto do repositório forkado do desafio) e a armazeno como uma string na propriedade Placa da classe Entrada.
 - Registro o momento da entrada utilizando o método Now da classe DateTime e armazeno na propriedade Hora da classe Entrada.
 - Adiciono a instância da classe Entrada na lista de veículos.
#### Método RemoverVeiculo
 - Solicito a placa do veículo.
 - Crio uma instância da classe Entrada.
 - Verifico com a condicional se o retorno do método Find é diferente de nulo.
 - Dentro da condicional, capturo o momento da saída do veículo.
 - Utilizo o método Subtract para criar um objeto TimeSpan.
 - Armazeno a diferença em minutos como um número inteiro.
 - Realizo cálculos para verificar o valor final.
 - Utilizo o método Remove para remover o objeto retornado pelo método Find da lista.
#### Método ListarVeiculos
 - Loop que percorre a lista e imprime no console a placa de cada veículo ainda dentro do estacionamento e a hora de sua entrada.

# Descritivo Original do Desafio


## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.



