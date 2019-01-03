def main():
    p = Player()
    p.setMode("MP3")
    p.play()
    p.setMode("Cassete")
    p.play()
    p.setMode("LP")
    p.play()

if __name__ == '__main__':
    teste = main()

teste