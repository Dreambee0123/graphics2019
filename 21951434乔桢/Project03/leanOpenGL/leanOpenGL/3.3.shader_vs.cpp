#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTexCoords;

out vec2 TexCoords;
out vec3 Normal;
out vec3 FragPos;

//uniform float offset;
//uniform mat4 transform;
uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat3 normalMat;

void main()
{
    gl_Position = projection * view * model * vec4(aPos, 1.0);
	TexCoords = aTexCoords;
	Normal = normalMat * aNormal;

	FragPos = vec3(model * vec4(aPos, 1.0));
	//FragPos = vec3(view * model * vec4(aPos, 1.0));
}