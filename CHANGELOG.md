
# Change Log

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## [3.0.0] - 2025-02-20

Full conversion of project to UPM Package

### Added

- Change log
- Included support for Unity 6 with backward compatibility

## Changed

- Project structure for UPM package setup with instructions on installation

## Fixed

- Unused Imports

## [2.0.1] - 2024-07-07

### Fixed

- Instance caused a stack overflow

## [2.0.0] - 2024-01-23

Major revision of the singletons implementation

### Added

- Added `PersistentMonoSingleton` which is persistent across scenes
- Added `ISingleton` interface for unifying the methods and calls
- Added assembly definition
- Added namespace (`UnityCommunity.UnitySingleton`)

### Changed

- Made `MonoSingleton` non-persistent

## [1.2.1] - 2024-01-22

### Fixed

- Added missing methods for `MonoSingleton`

## [1.2.0] - 2017-12-2

### Added

- Init for existing instance and basic editor mode support

## [1.1.0] - 2023-11-27

### Added

- Scene `Singleton` (or Local Singleton) for non-persistent singletons across scene changes
- `MonoSingleton` to quickly extend `MonoBehaviour` as singletons

### Changed

- Extended Generic `Singleton` class with additional virtual functions (earlier this was extending `MonoBehaviour`)

## [1.0.0] - 2017-09-16

### Added

- Base files for the project with a generic `Singleton`
