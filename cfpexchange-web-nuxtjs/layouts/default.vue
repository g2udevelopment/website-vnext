<template>
  <div class="flex flex-col">
    <nav class="bg-gray-800 flex py-4 px-6 justify-between items-center">
      <Brand />
      <ul class="flex text-white">
        <li>
          <nuxt-link to="/" class="px-6 py-7 font-semibold hover:text-gray-200">Home</nuxt-link>
        </li>
        <li>
          <nuxt-link to="/cfp" class="px-6 py-7 font-semibold hover:text-gray-200">CFP's</nuxt-link>
        </li>
        <li>
          <nuxt-link to="/about" class="px-6 py-7 font-semibold hover:text-gray-200">About</nuxt-link>
        </li>
        <li>
          <nuxt-link to="/contact" class="px-6 py-7 font-semibold hover:text-gray-200">Contact</nuxt-link>
        </li>
      </ul>
      <div class="text-white border-gray-500 border px-3 py-2 rounded-md">Submit CFP</div>
    </nav>
    <div>
      <Nuxt />
    </div>
    <footer class="bg-gray-600">
      <div class="container mx-auto px-6 pt-10 pb-6">
        <div class="flex text-white">
          <div class="w-full text-center font-bold"><h5>About</h5></div>
          <div class="w-full text-center font-bold"><h5>Follow us</h5></div>
          <div class="w-full text-center font-bold"><h5>CFP's</h5></div>
          <div class="w-full text-center font-bold"><h5>Newsletter</h5></div>
        </div>
      </div>
    </footer>
  </div>
</template>
