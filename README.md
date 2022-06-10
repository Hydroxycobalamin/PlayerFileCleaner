PlayerFileCleaner
-----------------

PlayerFileCleaner cleans your playerdata in your world folders.

It tries to convert V3(cracked player data) and other obscure player data to valid V4 by calling the Mojangs API.
Optional it can also remove bedrock(Geyser) playerdata, if you want that.

PlayerFileCleaner will log what it does. You can find logs and backups inside a PlayerFileCleaner folder in your selected output path.

### Dependencies

1. PlayerFileCleaner requires [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

### How to use

1. Download PlayerFileCleaner from the Releases tab or build it yourself.
2. Create a .json file which contains the uuids and player names of your players on your server. You can use Denizen and this script to generate the file automatically.
    1. Install [Denizen](https://github.com/Hydroxycobalamin/Denizen-Script-Collection) on your server.
    2. Drag and drop the [Player Exporter](https://forum.denizenscript.com/resources/player-exporter.105/) into your /plugins/Denizen/scripts folder.
    3. Run `/ex reload`
    4. Run `/ex run player_exporter`
    5. Stop the server
3. Create a backup of your server, just in case something borks.
4. Start PlayerFileCleaner and tick the options you want.
5. Select the .json file you just generated.
6. Select an output folder in which PlayerFileCleaner saves logs and backups player files.
7. Select a world folder you want to clean.
8. Click on Start
9. Repeat step 7 and 8 with each world containing a playerdata or advancements folder.

### The short of the license is:

You can do basically whatever you want, except you may not hold any developer liable for what you do with the software.

### The long version of the license follows:

The MIT License (MIT)

Copyright (c) 2022 Hydroxycobalamin

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.