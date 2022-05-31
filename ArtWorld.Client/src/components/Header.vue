<template>
    <header class="border-b border-gray-800">
        <nav class="container mx-auto flex flex-col lg:flex-row items-center justify-between px-4 py-6">
            <div class="flex flex-col lg:flex-row items-center">
                <router-link :to="{ name: 'home' }">
                    <img src="../assets/images/logo.svg" alt="Logo" class="w-20 flex-none" />
                </router-link>

                <ul class="flex ml-0 lg:ml-16 space-x-8 mt-6 lg:mt-0">
                    <li>
                        <a href="#" class="hover:text-gray-400">Аниме</a>
                    </li>
                    <li>
                        <a href="#" class="hover:text-gray-400">Популярные</a>
                    </li>
                    <li>
                        <a href="#" class="hover:text-gray-400">Скоро</a>
                    </li>
                </ul>
            </div>

            <div class="flex items-center mt-6 lg:mt-0">
                
                <div class="relative">
                    <input
                        type="text"
                        class="bg-gray-800 text-sm rounded-full focus:outline-none focus:shadow-outline w-64 px-3 pl-8 py-1"
                        placeholder="Поиск..."
                    />
                
                    <div class="absolute top-0 flex items-center h-full ml-2">
                        <img src="../assets/images/lupa.svg" alt="Lupa" class="w-4">
                    </div>
                
                    <div class="absolute z-50 bg-gray-800 text-sm rounded w-64 mt-2">
                        <ul>
                            <li class="border-b border-gray-700">
                                <a href="#" class="block hover:bg-gray-700 flex items-center transition ease-in-out duration-150 px-3 py-3">
                                    <img 
                                        src="https://cdn.myanimelist.net/images/anime/1079/109928.jpg?s=33c1c9c33504d732712ca3e1ebcafc7a" 
                                        alt="cover" 
                                        class="w-10"
                                    />
                                    <span class="ml-4">Название аниме из поискового дропдовна</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>

                <div class="ml-6">
                    <a href="#">
                        <img src="../assets/images/avatar.png" alt="avatar" class="rounded-full w-8">
                    </a>
                </div>
            </div>
        </nav>
    </header>
</template>

<script>
export default {
    name: 'Header'
}
</script>
