TODO

Open root directory

Parse Hierarchical subdirectories

Cache File infos:
	- DirectoryName
	- FileName

Read exif infos :
	- DateTimeOriginal
	- Orientation
	- Marque appareil
	- Modèle appareil
	- longitude
	- latitude
	- altitude (?)

Rebuild  Hierarchical subdirectories on new root by:
	- Year (format yyyy)
	- Month  (format yyyy-MM)

Rename photos with <DateTimeOriginal> <descritpion> with :
	- DateTimeOriginal in format yyyy-MM-dd hh:mm
	- if filename start with "DSCN", descritpion = filename without extension
	- if filename start with "IMG_", descritpion = filename without "_" and extension
	- if filename start with "WP_", descritpion = "WP"
	- if filename start with "P", descritpion = filename without extension
	- else description = null