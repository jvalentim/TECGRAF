class Player:
    def setMode(self, mode):
        self.data = mode
        return self.data

    def play(self):
        if(self.data == "MP3"):
            return MP3Player.play(self)
        elif (self.data == "Cassete"):
            return CassetePlayer.play(self)