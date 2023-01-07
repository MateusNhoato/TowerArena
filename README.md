# Tower Arena
[![Versão](https://img.shields.io/badge/vers%C3%A3o-0.3.0-brightgreen.svg)](https://github.com/user/repo/releases)

Este é um jogo que fiz para praticar programação orientada a objetos. É um simulador de combate em turnos, entre um jogador e inimigos gerados automaticamente. 

## Tecnologias
[![Tipo de aplicação](https://img.shields.io/badge/aplica%C3%A7%C3%A3o-console-blue.svg)](#)

[![Paradigma](https://img.shields.io/badge/paradigma-POO-blue.svg)](#)

[![Linguagem](https://img.shields.io/badge/linguagem-C%23-brightgreen.svg)](https://docs.microsoft.com/pt-br/dotnet/csharp/)

## Download da última versão:
[![Download](https://img.shields.io/badge/Download-drive-brightgreen.svg)](https://drive.google.com/file/d/1qmMp5Gq0KjfKH-aP56b0T7cDfdVqUJKZ/view?usp=share_link)

## Demonstração
![TowerArena1](https://media.giphy.com/media/Ql7b2JUi8Hp9UsM5jH/giphy.gif)

## Descrição
O jogo se passa em uma torre de 10 andares. Para passar para o próximo andar basta derrotar o Chefe do Andar 👺
mas, para chegar até ele, você precisa desafiar 10 combatentes e sair vitorioso de cada combate 👊(ou, se é um Ladrão, pode fugir do combate🏃). Derrotando todos os 10 Chefes de Andar você ganha o jogo🏆!

## Tutorial
Para começar a jogar basta criar um novo personagem a partir do menu principal do jogo. Após escolher o nome de seu personagem, você pode escolher entre uma das 4 classes.✅ 

## Mecânicas do jogo
### Andar
 Após entrar em um Andar você só pode seguir em frente, isto é, os combates são seguidos um do outro, sem tempo para usar poções entre eles. Há somente duas pausas, a primeira é logo após o Round 5️⃣ e a segunda é antes de enfrentar o Chefe do Andar, após o Round 🔟. 
### Classes
Cada classe tem suas fraquezas e vantagens, mas todos começam com 2️⃣ poções de Vida e 2️⃣ poções de mana.
As classes básicas são: 
- Arqueiro 🏹 
- Conjurador 🧙‍♂️ 
- Guerreiro ⚔️
- Ladrão 🗡️

### Habilidades especiais
Cada classe conta com 4 habilidades especiais únicas e uma habilidade passiva. Todas as habilidades tem algum custo (seja vida ou mana), além de uma quantidade de usos possíveis. Estes usos são resetados antes de entrar no Andar e nos Rounds 5️⃣ e 🔟.

### Subclasses
Ao atingir o nível 11, o jogador pode escolher uma subclasse à partir da sua escolha de classe básica.
- **Arqueiro**: 
    - Ranger 🐺 e Atirador 🎯
- **Ladrão**:
    - Ladino 🐱‍👤 e Mercenário 💰
- **Conjurador**:
    - Mago 🔥 e Feiticeiro 👿 
- **Guerreiro**:
    - Espadachim ⚔ e Cavaleiro 🛡️ 


Cada subclasse também tem uma maneira distinta de jogar, com quatro habilidades únicas e uma habilidade passiva. 

### Atributos
As classes ganham atributos por nível e cada classe tem um atributo principal (o atributo que é usado para tentar acertar o oponente e que também é usado para o cálculo de dano dos ataques e habilidades da classe).

#### Agilidade 💨
Usado como atributo principal para o Ladrão,Ladino e Atirador.
Também é utilizado para o cálculo de Esquiva de cada personagem.

#### Força 💪
Usado como atributo principal para o Guerreiro, Mercenário e Cavaleiro.
Também é utilizado para o cálculo de regeneração pós combate de cada personagem, isto é, entre cada combate o jogador recupera sua Força Total em Vida.

#### Intelecto 🧠
Usado como atributo principal para o Conjurador, Mago e Feiticeiro.
Também é utilizado para o cálculo de regeneração pós combate de cada personagem, isto é, entre cada combate o jogador recupera seu (Intelecto Total/2) em Mana.

#### Defesa 🛡
Utilizado para o cálculo de Vida Máxima de cada classe e a Defesa em si de cada personagem.

#### Hibrido 💨/💪
Usado como atributo principal para o Arqueiro, Ranger e Espadachim.
É um atributo coringa, para classes que não se destacam só em uma área. Ele calcula qual dos atributos entre Agilidade e Força é maior, e então o utiliza. 

### Itens Consumíveis 🧪
O jogo conta com poções de regeneração (uma de Vida e outra de Mana) e poções de status (uma para cada um dos status básico do jogo,  Agilidade, Intelecto, Defesa e Força).Ao utilizar uma poção de status nos momentos de pausa (antes do round 6 e antes do chefe) você começa a próxima luta com os buffs, mas não carregará os buffs para um Round seguido deste.

## Contribuição

Se você quiser contribuir para o projeto, basta seguir os seguintes passos:

1. Faça um fork do repositório.
2. Crie uma nova branch com suas alterações: 
```
git checkout -b my-new-feature
```
3. Commit suas alterações: 
```
git commit -am 'Adicionei uma nova feature'
```
4. Envie sua branch: 
```
git push origin my-new-feature
```
5. Crie uma nova solicitação de pull.

