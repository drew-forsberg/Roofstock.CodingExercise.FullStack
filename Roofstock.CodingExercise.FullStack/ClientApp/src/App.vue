<template>
  <nav-menu></nav-menu>
  <home />
</template>

<script>
    import NavMenu from './components/NavMenu.vue'
    import Home from './components/Home.vue'

export default {
  name: 'App',
  components: {
      NavMenu,
      Home
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
