# Syx's Actor Tool
A dotnet tool used to modify video game actor files, optimized for The Legend of Zelda: Tears of the Kingdom. Theoretically, it would work for other games which utilize the same file structure. At no point does this tool contain assets or code belonging to Nintendo. I don't really have a name for this tool yet, so I've called it that with my [psuedonym](https://en.wikipedia.org/wiki/Pseudonym). 

If you need help providing a RomFS for the game, you may want to [look here for help with modding your Nintendo Switch](https://switch.hacks.guide/) and dumping the game files, google is a good friend here.

This tool is currently in pre-alpha, which means it does not provide any use above launching and internal actions. Once this program can change actor files with some unique functionality, it enters alpha. At that point, I will provide build releases to the public.

This tool enters beta when I feel like it.

# Why?
Tears of the Kingdom's modding scene feels very hostile when it comes to modifying actor files, making anything new breaks at just the slightest hint of an error, and I've had so many issues with it myself that instead of spending 10 minutes trouble shooting, I'd spend 6 months of my life making and remaking a tool to make it easier. This is the 3rd attempt.

I want to ultimately provide a way for users to open a folder to work on their mods in, automatically modifying their __provided__ game files as well as generating new files based on presets (i.e., sword, spear, armor, material) as well as modifying other files as needed, providing a user-friendly interface.

# To Do
Below is a list of things that need to be done before this software enters alpha.
- Anything.
- A tool that can open actor files, providing a visual interface to modify actor files easily via text editor.

While in Alpha, the following need to be done. This will act as a checklist for the program to enter Beta where I feel it could be truly beneficial as a tool. They don't all need to be complete by then, but it is an indication of progress. More may be added to the list depending on what I can think of. If it is crossed out, this has been achieved.
- Templates to create new actor files with fields that can be modified and are displayed to the user on actor creation.
- Specialized menu for specific actor types, i.e. sword, shield, bow, material.
    - Specialized to display and modify thumbnails.
- The ability to create actors without provided game dump (minus compression, as such requires a game dump.)
- User customizability, themes, font size, etc.
- Add to existing mods or create "projects" which can utilize existing files in a mod.
    - Compatibility with TKMM.

# Building & Dependencies
To build this tool, you need...
WIP

# Special Thanks
penguintbh
