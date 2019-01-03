class Player:
    def setPlayable(self, playable):
        self.playable = playable

    def play(self):
        self.playable.play()