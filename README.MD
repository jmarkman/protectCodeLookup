# PPC Lookup Database

# Update 1/3/2017
# Deprecated due to integration of this kind of service into a gigantic corporate web portal

At work, we used to use a 9 megabyte Excel spreadsheet to look up [Public Protection Codes] for certain properties. This used to take an age because Excel had to load, and then the spreadsheet needed to do a vlookup for the counties, and then a vlookup for the towns and then one for the protection codes themselves. It was pretty ridiculous and added a lot more time than people think to completing a process at work (takes about 10 seconds per location if they're spread out). These codes also update every two years or so, and updating them while they're in a spreadsheet is incredibly time-consuming. Putting them on a database and just calling SQL queries to update or add entries is much faster than hunt-and-peck through a
spreadsheet.

It's written in C#. I was advised to not get crazy about design philosophy like MVC and MVVM. Without comments it's about 100 LOC. The program is meant to be launched via a call from an entirely different Excel spreadsheet (click a button, that button uses Shell(ppcLookup) in VBA to launch it) which is part of a larger process here at work.

[Public Protection Codes]: https://firechief.iso.com/FCWWeb/mitigation/ppc0001.jsp
