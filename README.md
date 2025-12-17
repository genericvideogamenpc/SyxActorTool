# Syx's Actor Tool
A dotnet tool used to modify video game actor files, optimized for The Legend of Zelda: Tears of the Kingdom. Theoretically, it would work for other games which utilize the same file structure. At no point does this tool contain assets or code belonging to Nintendo. I don't really have a name for this tool yet, so I've called it that with my [psuedonym](https://en.wikipedia.org/wiki/Pseudonym). 

If you need help providing a RomFS for the game, you may want to [look here for help with modding your Nintendo Switch](https://switch.hacks.guide/) and dumping the game files, google is a good friend here.

This tool is currently in pre-alpha, which means it does not provide any use above launching and internal actions. Once this program can change actor files with some unique functionality, it enters alpha. At that point, I will provide build releases to the public.

This tool enters beta when I feel like it.

# Why?
Tears of the Kingdom's modding scene for modifying actor files isn't very well developed, making anything new breaks at just the slightest hint of an error, and I've had so many issues with it myself that instead of spending 10 minutes trouble shooting, I'd spend 6 months of my life making and remaking a tool to make it easier. This is the 3rd attempt, because the other two times I failed or I chose [Java](https://www.merriam-webster.com/dictionary/bad).

I want to ultimately provide a way for users to open a folder to work on their mods in, automatically modifying their __provided__ game files as well as generating new files based on presets (i.e., sword, spear, armor, material) and also modifying other files as needed, providing a user-friendly interface.

# To Do
Below is a list of things that need to be done before this software enters alpha.
- Anything.
- A tool that can open actor files, providing a visual interface to modify actor files easily via text editor.

While in Alpha, the following need to be done. This will act as a checklist for the program to enter Beta where I feel it could be truly beneficial as a tool. They don't all need to be complete by then, but it is an indication of progress. More may be added to the list depending on what I can think of. If it is crossed out, this has been achieved.
- Templates to create new specific types of actor files.
- Specialized menu for specific actor types, i.e. sword, shield, bow, material.
    - Specialized to display and modify thumbnails.
    - Change specific attributes in easy to access 
- The ability to create actors without provided game dump (minus compression, as such requires a game dump.)
- User customizability, themes, font size, etc.
- Add to existing mods or create "projects" which can utilize existing files in a mod.
    - Compatibility with TKMM.

# Building & Dependencies
To build this tool, you need to have .NET 8 installed and can open it in VS Code, Visual Studio, or really any IDE or text editor, as all you need to build is .NET 8.

### Windows
1. Download and install [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) for your system.

2. Clone the project or download the zip and extract it somewhere.

3. Open the terminal (Powershell or Cmd should work, untested!) in the project folder and run the following:
`dotnet build --configuration Release`

If you have no errors, you can find the build in the bin folder.

### Linux
Install .NET 8 for your system. If you also don't already have git, you can just add git to both.

On Debian based systems, run `sudo apt install dotnet-sdk-8`.

On Arch based systems, run `sudo pacman -S dotnet-sdk-8`.

Next, run the following:
```
git clone https://github.com/genericvideogamenpc/SyxActorTool.git

cd SyxActorTool/

dotnet build --configuration Release
```
# Special Thanks
[Penguintbh](https://www.youtube.com/@penguintbh) for leading me to starting this project. Check out their channel, its pretty cool.

[Timber](https://www.youtube.com/@Timberwolfee) for inspiring me to look into how Tears of the Kingdom works, directly leading me to learn how to mod a video game for the... second time.

[The Second Amendment](https://constitution.congress.gov/constitution/amendment-2/). No, seriously, check out my mods on [GameBanana](https://gamebanana.com/members/3273745), I made a silly and also broken as hell mod that led to this tool being made.