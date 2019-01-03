class Player:
    def setMode(self, mode):
        self.playable = mode

    def play(self):
        if(self.playable == "MP3"):
            return MP3Player.play(self)
        elif (self.playable == "Cassete"):
            return CassetePlayer.play(self)
        elif (self.playable == "LP"):
            return LPPlayer.play(self)