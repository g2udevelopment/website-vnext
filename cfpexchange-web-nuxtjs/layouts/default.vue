<template>
  <div class="flex flex-col">
    <nav class="bg-gray-800 flex p-2 justify-between">
      <Brand />
      <ul class="flex text-white">
        <li>
          <nuxt-link to="/">Home</nuxt-link>
        </li>
        <li>
          <nuxt-link to="/about">About</nuxt-link>
        </li>
        <li>
          <nuxt-link to="/contact">Contact</nuxt-link>
        </li>
      </ul>
      <div>
        Button
      </div>
    </nav>
    <div>
      <Nuxt />
    </div>
  </div>
</template>
