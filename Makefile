APP_NAME = chessviz
LIB_NAME = cw-ip-011-optimal_trafic
TEST_NAME = chessviz-test

CC = gcc
CFLAGS = -Wall -Wextra -Werror
CPPFLAGS = -I src -I thirdparty -MP -MMD

VS_DIR = .vs
v16_DIR = v16 

	#change this to the name of the Main class file, without file extension
MAIN_FILE = $(LIB_NAME)/$(VS_DIR)/$(LIB_NAME)/$(v16_DIR)

#change this to the depth of the project folders
#if needed, add a prefix for a common project folder
CSHARP_SOURCE_FILES = $(wildcard */*/*.cs */*.cs *.cs)

#add needed flags to the compilerCSHARP_FLAGS = -out:$(EXECUTABLE)
CSHARP_FLAGS = -out:$(EXECUTABLE)

#change to the environment compiler
CSHARP_COMPILER = mcs

#if needed, change the executable file
EXECUTABLE = $(MAIN_FILE).suo

#if needed, change the remove command according to your system
RM_CMD = -rm -f $(EXECUTABLE)
all: $(EXECUTABLE)

$(EXECUTABLE): $(CSHARP_SOURCE_FILES)
    @ $(CSHARP_COMPILER) $(CSHARP_SOURCE_FILES) $(CSHARP_FLAGS)
    @ echo compiling...

run: all
    ./$(EXECUTABLE)

clean:
    @ $(RM_CMD)

remake:
    @ $(MAKE) clean
    @ $(MAKE)