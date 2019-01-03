def main():
    p = Player()
    p.setPlayable(MP3Player())
    p.play()
    p.setPlayable(CassetePlayer())
    p.play()
    p.setPlayable(LPPlayer())
    p.play()

if __name__ == '__main__':
    teste = main()

teste
