1 arquivo
MAIN - main.py
 
+ 3 arquivos com 1 classe em cada
classe 1- Player dentro de Player.py
classe 2- MP3Player dentro de MP3Player.py
classe 3- CassetePlayer dentro de CassetePlayer.py


PSEUDO CODIGO:
________________________
Arquivo 1 - main.py

var p = Player()

p.setMode("MP3")
p.play()
p.setMode("Cassete")
p.play()

output do programa deve ser:

Ao rodar programa o resulatdo deve ser impresso no console como : 
> "playing mp3"
> "playing cassete"

_________________________
Arquivo 2- MP3 Player
está ok

____________________________
Arquivo 3 - CassetePlayer 
ok
_________________________
Arquivo 4 - Player - Classe que toca mp3 ou cassete, mas não sabe como, recorre as classes mp3player e cassetePlayer (Delegation)

playmode = ""
mp3Player = MP3Player()
cassetePlayer = CassetePlayer()

setMode(mode)
{
    playMode = mode
}

play() 
{
    if(playMode == "MP3")
        mp3Player.play()
    else if(playMode == "Cassete")
        cassetePlayer.play()
}
