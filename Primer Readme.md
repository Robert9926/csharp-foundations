# CSharp Foundations

## Descripción

Este repositorio cumple la función como un primer entregable para realizar practica y desarrollo con la tecnologia de Git, al igual que hacer pruebas con los distintos comandos y funciones de Git.

## Objetivo del Repositorio

Generar 3 ramas y conflictos entre ellas para poder despues tener la capacidad de resolverlos.

## Tecnologias Usadas

- Git
- Markdown
- GitHub

## Ejercicio de Git

Generar 3 ramas y ocasionar de manera intencional y resolver un error al momento de juntarlas que Git no pueda resolver de manera automatica.

## Creación de ramas

Se generaron 2 ramas a partir de la rama principal `main`, `rama-2` y `rama-3`.

## Generación del conflicto

En las 3 ramas, se modificaba una sola linea de texto del mismo archivo. al momento de querer unirlas con `merge` surgia un error que Git no podia resolver de manera automatica. El cual señalaba la linea especifica que estaba modifica de manera distinta en cada rama.

**_Correción_** : Git detecto un conflicto de `merge`debido a que la misma linea fue modificada en múltiples ramas.

## Resolución del Conflicto

Se resolvio de manera manual la linea que ocasionaba el conflicto entre la rama `rama-2`y `main`, despues el conflico entre `rama-3` y `main`.

## Conceptos de Git Aprendidos

- Grafos
- conflictos
- ramas
- merge
- rebase
- soluciones manuales

## Estructura del Repositorio
