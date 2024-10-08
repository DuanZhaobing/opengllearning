cmake_minimum_required(VERSION 3.10)

project(OpenGLTutorial VERSION 1.0)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)

find_package(OpenGL REQUIRED)

# Set OpenGL directory
set(OPENGL_DIR "${CMAKE_SOURCE_DIR}/external/opengl")

# Set STB directory
set(STB_DIR "${CMAKE_SOURCE_DIR}/external/stb")

# Set CAMERA directory
set(CAMERA_DIR "${OPENGL_DIR}/camera")

# Set GLFW directory
set(GLFW_DIR "${OPENGL_DIR}/glfw")
set(GLFW_INCLUDE_DIR "${GLFW_DIR}/include")
set(GLFW_LIB_DIR "${GLFW_DIR}/lib")
set(GLFW_LIB "glfw3")

# Set GLAD directory
set(GLAD_DIR "${OPENGL_DIR}/glad")
set(GLAD_INCLUDE_DIR "${GLAD_DIR}/include")
set(GLAD_SRC "${GLAD_DIR}/src/glad.c")

# Set GLM directory
set(GLM_DIR "${OPENGL_DIR}/glm")

# Add resource files
file(GLOB JPG_FILES "${CMAKE_SOURCE_DIR}/resource/*.jpg")

foreach(JPG_FILE ${JPG_FILES})
  set(JPG_SOURCES ${JPG_SOURCES} ${JPG_FILE})
endforeach()

# Add source file
set(SOURCES main.cpp "${GLAD_SRC}")

# Add executable
add_executable(Tutorial "${SOURCES}")

# Add library
target_link_libraries(Tutorial "${GLFW_LIB_DIR}/glfw3.lib")

# Add include directory
target_include_directories(
  Tutorial PUBLIC "${OPENGL_DIR}" "${STB_DIR}" "${CAMERA_DIR}" "${GLM_DIR}" "${GLFW_INCLUDE_DIR}"
                  "${GLAD_INCLUDE_DIR}" "${GPG_SOURCES}")
