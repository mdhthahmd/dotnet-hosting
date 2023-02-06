<script setup>
import AnimatedPlaceHolder from '@/components/AnimatedPlaceHolder.vue';
</script>

<template>
    <li class="relative flex space-x-6 py-6 xl:static">
        <AnimatedPlaceHolder height="3.5rem" width="3.5rem" borderRadius="50%" />
        <div class="flex-auto">
            <AnimatedPlaceHolder height="24px" width="150px" />
            <dl class="mt-2 flex flex-col text-gray-500 xl:flex-row">
                <div class="flex items-start space-x-3">
                    <AnimatedPlaceHolder height="17px" width="250px" />
                </div>
            </dl>
        </div>
    </li>
</template>