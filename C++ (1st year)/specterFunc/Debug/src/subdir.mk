################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/function.cpp \
../src/generatorFibonacci.cpp \
../src/linearIndex.cpp \
../src/specter2HTML.cpp \
../src/specterBuilder.cpp \
../src/specterFunc.cpp 

O_SRCS += \
../src/functionItself.o \
../src/linearIndex.o \
../src/specter2HTML.o \
../src/specterFunc.o 

OBJS += \
./src/function.o \
./src/generatorFibonacci.o \
./src/linearIndex.o \
./src/specter2HTML.o \
./src/specterBuilder.o \
./src/specterFunc.o 

CPP_DEPS += \
./src/function.d \
./src/generatorFibonacci.d \
./src/linearIndex.d \
./src/specter2HTML.d \
./src/specterBuilder.d \
./src/specterFunc.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: Cross G++ Compiler'
	g++ -O0 -g3 -Wall -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


