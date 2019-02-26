echo "Starting build for project"
echo "Dir: $PWD"

DIR=$PWD

xbuild src/SoilMoistureI2CSensorCalibratedPump.sln /p:Configuration=Release
