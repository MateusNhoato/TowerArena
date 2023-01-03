# Tower Arena
Este é um jogo que fiz para praticar programação orientada a objetos. É um simulador de combate de turnos, entre um jogador e inimigos gerados automaticamente. 

O jogo se passa em uma torre de 10 andares. Para passar para o próximo andar basta derrotar o Chefe do Andar, mas para chegar nele você precisa desafiar 10 combatentes e sair vitorioso de cada combate (ou, se é um Ladrão, pode fugir do combate). Derrotando todos o 10 Chefes de Andar você ganha o jogo!

## Tutorial
Para começar a jogar basta criar um novo personagem a partir do menu principal do jogo. Após escolher o nome de seu personagem, você pode escolher entre 4 classes básicas: Arqueiro, Conjurador, Guerreiro e Ladrão. Cada classe tem suas fraquezas e vantagens, mas todos começam com 2 poções de Vida e 2 poções de mana. As habilidades especiais também são diferentes para cada classe, mas todas as habilidades tem algum custo (seja vida ou mana), além de uma quantidade de usos possíveis. Estes usos são resetados nos Rounds 1,5 e 10 de cada Andar da Torre. Após entrar em um Andar você só pode seguir em frente, isto é, os combates são seguidos um do outro, sem tempo para usar poções entre eles. Há somente duas pausas, a primeira é depois do Round 5 e a segunda é antes de enfrentar o Chefe do Andar, após o Round 10. Ao utilizar uma poção de status nesses momentos de pausa você começa a próxima luta com os buffs, mas não carregará os buffs para um Round seguido deste.

### Subclasses
Ao atingir o nível 11, o jogador pode escolher uma subclasse à partir da sua escolha de classe básica. O Arqueiro pode escolher entre Ranger e Atirador, o Ladrão entre Ladino e Mercenário, o Conjurador entre Mago e Feiticeiro e o Guerreiro entre Espadachim e Cavaleiro. Cada subclasse também tem uma maneira distinta de jogar e uma habilidade passiva. 

### Atributos
As classes ganham atributos por nível e cada classe tem um atributo principal (o atributo que é usado para tentar acertar o oponente e que também é usado para o cálculo de dano dos ataques e habilidades da classe).

#### Agilidade
Usado como atributo principal para o Ladrão,Ladino e Atirador.
Também é utilizado para o cálculo de Esquiva de cada personagem.

#### Força
Usado como atributo principal para o Guerreiro, Mercenário e Cavaleiro.
Também é utilizado para o cálculo de regeneração pós combate de cada personagem, isto é, entre cada combate o jogador recupera sua Força Total em Vida.

#### Intelecto
Usado como atributo principal para o Conjurador, Mago e Feiticeiro.
Também é utilizado para o cálculo de regeneração pós combate de cada personagem, isto é, entre cada combate o jogador recupera seu Intelecto Total /2 em Mana.

#### Defesa
Utilizado para o cálculo de Vida Máxima de cada classe e a Defesa em si de cada personagem.

#### Hibrido
Usado como atributo principal para o Arqueiro, Ranger e Espadachim.
É um atributo coringa, para classes que não se destacam só em uma área. Ele calcula qual dos atributos entre Agilidade e Força é maior, e então o utiliza. 

### Itens Consumíveis
O jogo conta com poções de regeneração (uma de Vida e outra de Mana) e poções de status (uma para cada um dos status básico do jogo,  Agilidade, Intelecto, Defesa e Força).