<template>
  <div>
    <ul class="flex">
      <li class="m-4" v-for="contributor in contributors" :key="contributor.id">
        <div>{{ contributor.login }}</div>
        <div>Image</div>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  data() {
    return {
      contributors: [],
    }
  },
  async fetch() {
    console.log("fetch called");
    this.contributors = await fetch(
      'https://api.github.com/repositories/128419453/contributors'
    ).then((res) => res.json());
  },
}
</script>
