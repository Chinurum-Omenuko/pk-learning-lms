<script>
  import CourseContentWindow from "$lib/components/CourseContentWindow.svelte";
  import SideNav from "$lib/components/SideNav.svelte";

</script>

<main>
    <SideNav />
    <CourseContentWindow />

</main>

<style>
    main{
        display: grid;
        grid-template-columns: 1fr 4fr;
        height: 100vh;
        
    }
</style>