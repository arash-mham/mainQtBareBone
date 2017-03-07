#version 400

out vec4 outColor;
in vec3 worldNormal;
in vec3 worldPosition;
in vec3 fragmentColor;
uniform vec3 ambientLight;
uniform vec3 worldLightPosition;
uniform vec3 worldEyePosition;

void main(){

       //diffuse
       vec3 worldLightVector=normalize(worldLightPosition-worldPosition);
       float diffuseBrightness=dot(worldLightVector,normalize(worldNormal));
       vec3 diffuseLight=vec3(diffuseBrightness,diffuseBrightness,diffuseBrightness);

       //specular
      vec3 worldReflectedLightVector=reflect(-worldLightVector,worldNormal);
       vec3 worldEyeVector=normalize(worldEyePosition-worldPosition);
       float specularity=dot(worldReflectedLightVector,worldEyeVector);
       specularity=pow(specularity,50);
        vec3 specularLight=vec3(specularity,specularity,specularity);
        
       vec3 color=fragmentColor*ambientLight+fragmentColor*clamp(diffuseLight,0,1);//fragmentColor*clamp(specularLight,0,1);

       outColor = vec4(color, 1.0);
}