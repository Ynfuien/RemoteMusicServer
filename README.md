# RemoteMusicServer

It's a server side for [Remote Music](https://github.com/Ynfuien/RemoteMusic) app, that allows you to control media of your computer, from your phone.


# Installation
Download latest .exe from [releases](https://github.com/Ynfuien/RemoteMusicServer/releases) page, run it and that's it! At least from server side, because ofcourse, you have to install android app as well, for it to make any sense.


## Additional configuration
### Autostart
If you want the server to run on windows startup, you can throw it into user's startup folder:
`C:\Users\{USER}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`, where `{USER}` is just yours user folder name. If you go to `C:\Users`, you will find it! I also suggest you to check `Hide on start`, so you could forget about app whatsoever, and just use it when you need it.

### Port
Default port is... default, if you want to change it, just do it. But don't forget to change it also on mobile!

### Config file
You can find config file in: `C:\Users\{USER}\AppData\Roaming\YApps\RemoteMusicServer`. It's very simple, so I didn't bother using JSON/YAML for it. Also, better leave it alone, I don't think you will ever need to touch it.



# Screenshots
![Settings](https://i.imgur.com/gCsL792.png)
![Debugg](https://i.imgur.com/kcVsfQR.png)


# Some last words...
This project was made mainly for my personal use, because I hated that I needed to stand up from my couch, just to change music volume on my pc. Also e.g [UnifiedRemote](https://www.unifiedremote.com/) didn't cut it, cause it only allows you to manage media from the app itself, and not by using volume buttons. Aand whether there was another app doing exacly what I wanted, I didn't bother searching for it xD

So, the app is as it is.
- there is no password or user system
- it only works on local network (same wifi for your pc and phone (it could work outside lan, if you forwarded some ports, but it would be insecure))
- everyone with this app, in the same network as you, can manage media on you computer. The only "barrier" is your port, that you can change to almost random
- app (server and mobile), is not beautiful, and will never be


# License
This project uses [GNU GPLv3](https://github.com/Ynfuien/RemoteMusicServer/blob/main/LICENSE.txt) license.